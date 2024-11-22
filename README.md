# GroveGames.GodotPackageTemplate

[![Build Status](https://github.com/grovegs/GodotPackageTemplate/actions/workflows/release.yml/badge.svg)](https://github.com/grovegs/GodotPackageTemplate/actions/workflows/release.yml)
[![Latest Release](https://img.shields.io/github/v/release/grovegs/GodotPackageTemplate)](https://github.com/grovegs/GodotPackageTemplate/releases/latest)
[![NuGet](https://img.shields.io/nuget/v/GroveGames.GodotPackageTemplate)](https://www.nuget.org/packages/GroveGames.GodotPackageTemplate)

This template provides a versatile .NET setup for creating both NuGet packages and Godot addons with minimal effort.

## 🛠️ Installation

To install the Godot Package Template, use the following command:

```bash
dotnet new install GroveGames.GodotPackageTemplate
```

---

## 📦 Create a New Package

Once installed, you can generate a new Godot package using the template:

```bash
dotnet new godotpackage --name "Behaviour Tree" --author "Grove Games" --github "grovegs" --description "A modular and extensible behavior tree framework for AI development in C# for the .NET and Godot Engine." --tags "godot;behaviour-tree"
```

### Parameters

- `--name`: **(Required)** The name of your package.
- `--author`: **(Required)** The author of the package.
- `--github`: **(Required)** Your GitHub username.
- `--description`: **(Optional)** A description for your package.
- `--tags`: **(Optional)** Semicolon-separated tags to categorize the package.

---

## 📂 Resulting Structure

The generated package will have the following structure:

```plaintext
├── .github/
│   ├── CODEOWNERS                 # Defines ownership for repository components
│   ├── dependabot.yml             # Automates dependency updates
│   └── workflows/
│       ├── ci.yml                 # CI/CD setup for building and testing
│       ├── format.yml             # Workflow for code formatting checks
│       ├── release.yml            # Workflow for managing releases
│       └── tests.yml              # Workflow for running unit tests
├── .vscode/
│   └── ...                        # VSCode project-specific settings
├── sandbox/
│   └── ...                        # Sandbox-related files
├── src/
│   ├── BehaviourTree/
│   │   ├── BehaviourTree.csproj   # Core library for your package
│   │   └── ...                    # Additional source files
│   ├── BehaviourTree.Godot/
│   │   ├── BehaviourTree.Godot.csproj  # Godot-specific library project
│   │   └── ...                         # Additional source files for Godot integration
├── tests/
│   ├── BehaviourTree.Tests/
│   │   ├── BehaviourTree.Tests.csproj  # Unit tests for the core package
│   │   └── ...                         # Test files
│   ├── BehaviourTree.Godot.Tests/
│   │   ├── BehaviourTree.Godot.Tests.csproj  # Unit tests for the Godot integration
│   │   └── ...                               # Test files
├── .editorconfig                  # Coding style configuration
├── .gitattributes                 # Git attributes for line endings and more
├── .gitignore                     # Git ignore rules
├── Directory.Build.props          # Shared MSBuild properties for the solution
├── Icon.png                       # Project icon
├── LICENSE                        # License information
├── README.md                      # Documentation for your package
├── global.json                    # Global .NET SDK configuration
└── BehaviourTree.sln              # Solution file for the package
```

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
