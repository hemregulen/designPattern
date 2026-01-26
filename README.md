# Design Pattern Examples

This repository contains implementations of various Design Patterns in C#. Each pattern includes both structural (theoretical) and real-world examples to help understand the pattern's purpose and application.

## 📋 Patterns Implemented

### 1. Abstract Factory Design Pattern
The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

- **Structural Example**: Basic implementation showing the pattern structure
- **Real-World Example**: Document factory creating different types of documents

### 2. Bridge Design Pattern  
The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.

- **Structural Example**: Basic bridge implementation
- **Real-World Example**: Database connection abstraction supporting multiple database types (SQL Server, PostgreSQL, Azure Synapse)

### 3. Facade Design Pattern
The Facade pattern provides a unified interface to a set of interfaces in a subsystem, making the subsystem easier to use.

- **Structural Example**: Basic facade with subsystems
- **Real-World Example**: Washing machine facade coordinating washing, rinsing, and spinning systems

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio 2022 or Visual Studio Code (optional)

### Building the Solution
```bash
dotnet build HEG.DesignPattern.sln
```

### Running Individual Projects
Each pattern has two projects (Structural and RealWorld). To run a specific example:

```bash
# Abstract Factory - Structural
dotnet run --project HEG.AbstractFactoryDesignPattern.Structural

# Abstract Factory - Real World
dotnet run --project HEG.AbstractFactoryDesignPattern.RealWorld

# Bridge - Structural
dotnet run --project HEG.BridgeDesignPattern.Structural

# Bridge - Real World
dotnet run --project HEG.BridgeDesignPattern.RealWorld

# Facade - Structural
dotnet run --project HEG.FacadeDesignPattern.Structural

# Facade - Real World
dotnet run --project HEG.FacadeDesignPattern.RealWorld
```

## 📁 Project Structure

```
designPattern/
├── HEG.AbstractFactoryDesignPattern.Structural/   # Abstract Factory structural example
├── HEG.AbstractFactoryDesignPattern.RealWorld/    # Abstract Factory real-world example
├── HEG.BridgeDesignPattern.Structural/            # Bridge structural example
├── HEG.BridgeDesignPattern.RealWorld/             # Bridge real-world example
├── HEG.FacadeDesignPattern.Structural/            # Facade structural example
├── HEG.FacadeDesignPattern.RealWorld/             # Facade real-world example
└── HEG.DesignPattern.sln                          # Visual Studio solution file
```

## 📖 Pattern Documentation

For detailed information about each pattern, see the README files in their respective directories:

- [Abstract Factory Pattern](./docs/AbstractFactory.md)
- [Bridge Pattern](./docs/Bridge.md)
- [Facade Pattern](./docs/Facade.md)

## 🎯 Learning Objectives

This repository aims to help developers:
- Understand the structure and intent of each design pattern
- See practical, real-world applications of each pattern
- Learn when and how to apply these patterns in their own projects
- Compare structural vs real-world implementations

## 📝 License

This project is open source and available for educational purposes.

## 👤 Author

**Hemre Gülen**

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!
