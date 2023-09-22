using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MIMIR_to_AES256_IV
{
    /// <summary>
    /// This class serves as a utility to convert an encrypted string from MIMIR TripleDES encryption to AES-IV encryption.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point for the application.
        /// </summary>A
        /// <param name="args">Command-line arguments (not used).</param>
        static void Main(string[] args)
        {
            // Generate a new AES Key (AES-256 requires 32 bytes)
            byte[] newKey = GenerateAESKey();

            // Convert the generated AES key to a Base64 string for easier handling and debugging
            string base64NewKey = Convert.ToBase64String(newKey);

            // Output the generated Base64-encoded AES Key and its length for verification
            Console.WriteLine($"Generated AES Key: {base64NewKey}");
            Console.WriteLine($"Generated AES Key Length: {newKey.Length} bytes");

            // Ask the user for the MIMIR-encrypted string
            Console.Write("Please enter the MIMIR TripleDES encrypted string: ");
            string mimirEncryptedString = Console.ReadLine();

            // Decrypt the MIMIR-encrypted string to plaintext
            string decryptedString = DecryptWithMimir(mimirEncryptedString);
            Console.WriteLine($"Decrypted with MIMIR: {decryptedString}");

            // Encrypt the plaintext string using AES-IV encryption
            string aesEncryptedString = EncryptWithAES(decryptedString, newKey);
            Console.WriteLine($"Encrypted with AES-IV: {aesEncryptedString}");
        }

        /// <summary>
        /// Generates a 32-byte (256-bit) key suitable for AES-256 encryption.
        /// </summary>
        /// <returns>A 32-byte key.</returns>
        public static byte[] GenerateAESKey()
        {
            // Use cryptographic-quality random number generator to create the AES key
            using (var rngCrypto = new RNGCryptoServiceProvider())
            {
                byte[] key = new byte[32];
                rngCrypto.GetBytes(key);
                return key;
            }
        }

        /// <summary>
        /// Decrypts a string that was encrypted using MIMIR's TripleDES encryption.
        /// </summary>
        /// <param name="encryptedString">The encrypted string.</param>
        /// <returns>The decrypted string.</returns>
        public static string DecryptWithMimir(string encryptedString)
        {
            using (var mS = new MIMIR.Security())
            {
                return mS.DecryptTripleDES(encryptedString);
            }
        }

        /// <summary>
        /// Encrypts a plaintext string using AES-IV encryption.
        /// </summary>
        /// <param name="decryptedString">The plaintext string to be encrypted.</param>
        /// <param name="key">The AES key to use for encryption.</param>
        /// <returns>The encrypted string.</returns>
        public static string EncryptWithAES(string decryptedString, byte[] key)
        {
            using (var aes = Aes.Create())
            {
                // Set the AES key
                aes.Key = key;

                // Output the length of the key being used for debugging purposes
                Console.WriteLine($"AES Key Length: {aes.Key.Length} bytes");

                // Generate a new Initialization Vector (IV) for AES encryption
                aes.GenerateIV();

                using (var memoryStream = new MemoryStream())
                {
                    // Write the IV to the beginning of the stream
                    memoryStream.Write(aes.IV, 0, aes.IV.Length);

                    using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        // Convert the plaintext string to a byte array
                        var inputBytes = Encoding.UTF8.GetBytes(decryptedString);

                        // Write the byte array to the crypto stream to perform encryption
                        cryptoStream.Write(inputBytes, 0, inputBytes.Length);

                        // Finalize the encryption process
                        cryptoStream.FlushFinalBlock();

                        // Convert the encrypted byte array to a Base64 string
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
            }
        }
    }
}
