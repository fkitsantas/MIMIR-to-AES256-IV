# MIMIR-to-AES256-IV .Net5

## Overview

MIMIR-to-AES256-IV is an utility program designed to decrypt an encrypted string using MIMIR's TripleDES algorithm and then encrypt it back using AES-IV encryption. This utility aims to assist in the transition from TripleDES encryption to AES encryption.

## Table of Contents

- [Overview](#overview)
- [Installation](#installation)
- [Usage](#usage)
- [Dependencies](#dependencies)
- [Contribution](#contribution)
- [License](#license)

## Installation

To install this utility, you'll need to have [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0) installed on your machine.

1. Clone the repository to your local machine:

   ```
   git clone https://github.com/fkitsantas/MIMIR-to-AES256-IV.git
   ```

2. Navigate to the project folder:

   ```
   cd MIMIR-to-AES256-IV
   ```

3. Build the project:

   ```
   dotnet build
   ```

4. Run the application:

   ```
   dotnet run
   ```

## Usage

Run the program and follow the prompt to input the encrypted string:

```
Please enter the MIMIR TripleDES encrypted string:
```

After input, the program will decrypt the string using MIMIR's TripleDES algorithm and will encrypt it back using AES-IV encryption. Both the decrypted and the newly encrypted strings will be printed to the console for your verification.

## Dependencies

- .NET 5
- MIMIR.dll (for TripleDES decryption)

## Contribution

We welcome contributions to this project. Please follow these guidelines:

1. Fork the repository and create your branch from `main`.
2. Make sure your code has proper comments and follows the existing style for consistency.
3. Issue a Pull Request with your changes and provide an explanation of what the changes entail.
  
## License

This project is licensed under the GNU AFFERO GENERAL PUBLIC LICENSE 3.0 License. See [LICENSE.md](LICENSE.md) for details.
