# MIMIR to AES256-IV (.Net Version Upgrade Experiment)

## Overview

This project serves as an experiment to migrate a solution from .NET 5 to .NET 7. The original solution was developed in .NET 5 using Visual Studio 2022. It was designed to decrypt strings encrypted with MIMIR's TripleDES algorithm and re-encrypt them using AES-IV encryption. The end goal was to understand the intricacies of migration, particularly in terms of references, dependencies, and backward compatibility.

## Table of Contents

- [Overview](#overview)
- [Learnings](#learnings)
- [Versions](#versions)
- [Contribution](#contribution)
- [License](#license)

## Learnings

This project has been an invaluable exercise in:

1. Understanding how references and dependencies are managed during migration.
2. Gaining insights into the backward compatibility of libraries compiled for earlier .NET versions (in this case, MIMIR.dll compiled for .NET 5).

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
