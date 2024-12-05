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
dotnet new godotpackage -na "Behaviour Tree" -au "Grove Games" -g "grovegs" -de "A modular and extensible behavior tree framework for AI development in C# for the .NET and Godot Engine." -ta "godot;behaviour-tree"
```

### Parameters

- `-na`: **(Required)** The name of your package.
- `-au`: **(Required)** The author of the package.
- `-g`: **(Required)** Your GitHub username.
- `-de`: **(Optional)** A description for your package.
- `-ta`: **(Optional)** Semicolon-separated tags to categorize the package.

---

## 📂 Resulting Structure

The generated package will have the following structure:

```plaintext
├── .github/
│   ├── CODEOWNERS                                          # Repository component ownership
│   ├── dependabot.yml                                      # Automates dependency updates
│   └── workflows/
│       ├── format.yml                                      # Workflow for code formatting checks
│       ├── release.yml                                     # Workflow for managing releases
│       └── tests.yml                                       # Workflow for running unit tests

├── .vscode/
│   └── settings.json                                       # VSCode project-specific settings

├── sandbox/
│   └── addons/                                             # Symbolic link to addon source

├── src/
│   ├── GroveGames.BehaviourTree/
│   │   ├── GroveGames.BehaviourTree.csproj                 # Core library project
│   │   └── ...                                             # Additional resources or files
│   ├── GroveGames.BehaviourTree.Godot/
│   │   ├── GroveGames.BehaviourTree.Godot.csproj           # Godot-specific library project
│   │   ├── addons/
│   │   │   └── GroveGames.BehaviourTree                    # Addon source files
│   │   └── ...                                             # Additional resources or files

├── tests/
│   ├── GroveGames.BehaviourTree.Tests/
│   │   ├── GroveGames.BehaviourTree.Tests.csproj           # Unit tests for core library
│   │   └── ...                                             # Test files and resources
│   ├── GroveGames.BehaviourTree.Godot.Tests/
│   │   ├── GroveGames.BehaviourTree.Godot.Tests.csproj     # Unit tests for Godot integration
│   │   └── ...                                             # Test files and resources

├── .editorconfig                                           # Code style and formatting configuration
├── .gitattributes                                          # Git attributes for line endings and more
├── .gitignore                                              # Git ignore rules
├── Directory.Build.props                                   # Shared MSBuild properties
├── Icon.png                                                # Project icon
├── LICENSE                                                 # License information
├── README.md                                               # Documentation for your package
├── global.json                                             # Global .NET SDK configuration
└── GroveGames.BehaviourTree.sln                            # Solution file for the package
```

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
