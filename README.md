# MIMIR to AES256-IV (.Net Version Upgrading Experiment)

## Overview

This project serves as an experiment to upgrade a solution from .NET 5 to .NET 7. The original solution was developed in .NET 5 using Visual Studio 2022. It was designed to decrypt strings encrypted with MIMIR's TripleDES algorithm and re-encrypt them using AES-IV encryption. The end goal was to understand the intricacies of migrating from a legacy .NET version to the most current release, particularly in terms of references, dependencies, and backward compatibility.

## Table of Contents

- [Overview](#overview)
- [Learnings](#learnings)
- [Versions](#versions)
- [Contribution](#contribution)
- [License](#license)

### Learnings

This project has been an invaluable exercise in:

1. **Software Development and Cryptography**: Creating the original .NET 5 solution was an exercise in best practices for secure coding and cryptography. Using TripleDES decryption via MIMIR.dll and implementing AES-IV encryption required a deep understanding of cryptographic algorithms and their implementation in C#.
2. **Migration Mechanics**: Understanding how references and dependencies are managed during an upgrade process. This provides insights into what components of the codebase are susceptible to breaking changes and how to address them.
3. **Backward Compatibility**: Gaining insights into the backward compatibility of libraries compiled for earlier .NET versions. In this case, the learning experience involved understanding how MIMIR.dll, which was compiled for .NET 5, interacts with a .NET 7 environment.


## Versions

The project has two main branches, each corresponding to a different .NET version:

- [.NET 5 Version](https://github.com/fkitsantas/MIMIR-to-AES256-IV/tree/dotNet5)
- [.NET 7 Version](https://github.com/fkitsantas/MIMIR-to-AES256-IV/tree/dotNet7)

Feel free to explore each to see the changes that were necessary to facilitate the migration.

## Contribution

Contributions are welcome. Please follow these guidelines:

1. Fork the repository and create your branch from the appropriate version branch (either `dotNet5` or `dotNet7`).
2. Ensure your code has proper comments and adheres to existing coding standards.
3. Submit a Pull Request explaining your changes and the version they apply to.

## License

This project is licensed under the GNU AFFERO GENERAL PUBLIC LICENSE 3.0 License. See [LICENSE.md](LICENSE.md) for details.
