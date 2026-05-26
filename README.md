# Design Pattern Examples

This repository contains all 23 Gang of Four (GoF) design patterns implemented in C# with both structural and real-world examples for each pattern.
## 📋 Patterns Implemented
### Creational
#### 1. Abstract Factory Design Pattern
Creates families of related objects without specifying concrete classes.

- **Structural Example**: Basic implementation showing abstract factories and product families.
- **Real-World Example**: Document factory creating related pages and sections.
#### 2. Builder Design Pattern
Separates the construction of a complex object from its representation.

- **Structural Example**: Basic builder with director and multiple concrete builders.
- **Real-World Example**: Computer assembly example that builds gaming and office PCs.
#### 3. Factory Method Design Pattern
Defines an interface for creating an object while letting subclasses decide which class to instantiate.

- **Structural Example**: Creator subclasses instantiate different concrete products.
- **Real-World Example**: Road and sea logistics create truck and ship transports.
#### 4. Prototype Design Pattern
Creates new objects by copying existing instances.

- **Structural Example**: Concrete prototypes clone themselves through a common abstraction.
- **Real-World Example**: Circle and rectangle shapes are copied and customized.
#### 5. Singleton Design Pattern
Ensures a class has only one instance and provides a global point of access to it.

- **Structural Example**: Thread-safe lazy singleton exposes one shared instance.
- **Real-World Example**: Application configuration is shared through a singleton store.
### Structural
#### 1. Adapter Design Pattern
Converts the interface of a class into another interface clients expect.

- **Structural Example**: Object adapter wraps an adaptee and exposes the target API.
- **Real-World Example**: A legacy printer is adapted to a modern printer interface.
#### 2. Bridge Design Pattern
Decouples an abstraction from its implementation so both can vary independently.

- **Structural Example**: Abstraction delegates work to interchangeable implementors.
- **Real-World Example**: Database connections are separated from database-specific implementations.
#### 3. Composite Design Pattern
Composes objects into tree structures to represent part-whole hierarchies.

- **Structural Example**: Leaf and composite nodes are treated uniformly.
- **Real-World Example**: Folders contain files and nested folders in a file system tree.
#### 4. Decorator Design Pattern
Attaches additional responsibilities to an object dynamically.

- **Structural Example**: Decorators wrap a component and add behavior around calls.
- **Real-World Example**: Coffee orders gain milk, sugar, and whip add-ons.
#### 5. Facade Design Pattern
Provides a unified interface to a set of interfaces in a subsystem.

- **Structural Example**: Facade simplifies access to multiple subsystem classes.
- **Real-World Example**: A washing machine facade coordinates wash, rinse, and spin systems.
#### 6. Flyweight Design Pattern
Uses sharing to support large numbers of fine-grained objects efficiently.

- **Structural Example**: Flyweights share intrinsic state while clients supply extrinsic state.
- **Real-World Example**: Text editor characters share font styles while positions stay unique.
#### 7. Proxy Design Pattern
Provides a surrogate or placeholder for another object.

- **Structural Example**: Proxy controls access to the real subject.
- **Real-World Example**: An image proxy delays loading until the image is displayed.
### Behavioral
#### 1. Chain of Responsibility Design Pattern
Passes a request along a chain of handlers until one handles it.

- **Structural Example**: Handlers either process a request or forward it to the next handler.
- **Real-World Example**: Support tickets flow from level 1 to level 3 support.
#### 2. Command Design Pattern
Encapsulates a request as an object.

- **Structural Example**: Invoker triggers command objects that act on a receiver.
- **Real-World Example**: Text editor insert and delete operations support undo and redo.
#### 3. Interpreter Design Pattern
Defines a representation for a grammar and an interpreter for sentences in the language.

- **Structural Example**: Expressions interpret a context through terminal and nonterminal rules.
- **Real-World Example**: A small parser evaluates addition and subtraction expressions.
#### 4. Iterator Design Pattern
Provides a way to access elements of an aggregate object sequentially without exposing its representation.

- **Structural Example**: Iterator traverses a custom aggregate independently of its storage.
- **Real-World Example**: A book collection exposes forward iteration through a dedicated iterator.
#### 5. Mediator Design Pattern
Defines an object that encapsulates how a set of objects interact.

- **Structural Example**: Colleagues communicate through a mediator instead of directly.
- **Real-World Example**: Chat room users send messages through a central chat room mediator.
#### 6. Memento Design Pattern
Captures and externalizes an object state so it can be restored later.

- **Structural Example**: Originator saves and restores state using mementos.
- **Real-World Example**: A text editor stores snapshots for undo.
#### 7. Observer Design Pattern
Defines a one-to-many dependency between objects so dependents are notified automatically.

- **Structural Example**: Observers subscribe to a subject and receive state updates.
- **Real-World Example**: Weather displays react to weather station measurements.
#### 8. State Design Pattern
Allows an object to alter its behavior when its internal state changes.

- **Structural Example**: Context delegates behavior to interchangeable state objects.
- **Real-World Example**: A traffic light transitions between red, green, and yellow states.
#### 9. Strategy Design Pattern
Defines a family of algorithms, encapsulates each one, and makes them interchangeable.

- **Structural Example**: Context switches between algorithm implementations at runtime.
- **Real-World Example**: Different sorting algorithms can be selected dynamically.
#### 10. Template Method Design Pattern
Defines the skeleton of an algorithm and lets subclasses redefine specific steps.

- **Structural Example**: Base class controls the algorithm while subclasses fill in primitive operations.
- **Real-World Example**: HTML and PDF reports share the same generation workflow with different body rendering.
#### 11. Visitor Design Pattern
Represents an operation to be performed on the elements of an object structure.

- **Structural Example**: Visitors operate on concrete elements without modifying their classes.
- **Real-World Example**: Area and perimeter visitors operate on circle and rectangle shapes.
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

# Builder - Structural
dotnet run --project HEG.BuilderDesignPattern.Structural

# Builder - Real World
dotnet run --project HEG.BuilderDesignPattern.RealWorld

# Factory Method - Structural
dotnet run --project HEG.FactoryMethodDesignPattern.Structural

# Factory Method - Real World
dotnet run --project HEG.FactoryMethodDesignPattern.RealWorld

# Prototype - Structural
dotnet run --project HEG.PrototypeDesignPattern.Structural

# Prototype - Real World
dotnet run --project HEG.PrototypeDesignPattern.RealWorld

# Singleton - Structural
dotnet run --project HEG.SingletonDesignPattern.Structural

# Singleton - Real World
dotnet run --project HEG.SingletonDesignPattern.RealWorld

# Adapter - Structural
dotnet run --project HEG.AdapterDesignPattern.Structural

# Adapter - Real World
dotnet run --project HEG.AdapterDesignPattern.RealWorld

# Bridge - Structural
dotnet run --project HEG.BridgeDesignPattern.Structural

# Bridge - Real World
dotnet run --project HEG.BridgeDesignPattern.RealWorld

# Composite - Structural
dotnet run --project HEG.CompositeDesignPattern.Structural

# Composite - Real World
dotnet run --project HEG.CompositeDesignPattern.RealWorld

# Decorator - Structural
dotnet run --project HEG.DecoratorDesignPattern.Structural

# Decorator - Real World
dotnet run --project HEG.DecoratorDesignPattern.RealWorld

# Facade - Structural
dotnet run --project HEG.FacadeDesignPattern.Structural

# Facade - Real World
dotnet run --project HEG.FacadeDesignPattern.RealWorld

# Flyweight - Structural
dotnet run --project HEG.FlyweightDesignPattern.Structural

# Flyweight - Real World
dotnet run --project HEG.FlyweightDesignPattern.RealWorld

# Proxy - Structural
dotnet run --project HEG.ProxyDesignPattern.Structural

# Proxy - Real World
dotnet run --project HEG.ProxyDesignPattern.RealWorld

# Chain of Responsibility - Structural
dotnet run --project HEG.ChainOfResponsibilityDesignPattern.Structural

# Chain of Responsibility - Real World
dotnet run --project HEG.ChainOfResponsibilityDesignPattern.RealWorld

# Command - Structural
dotnet run --project HEG.CommandDesignPattern.Structural

# Command - Real World
dotnet run --project HEG.CommandDesignPattern.RealWorld

# Interpreter - Structural
dotnet run --project HEG.InterpreterDesignPattern.Structural

# Interpreter - Real World
dotnet run --project HEG.InterpreterDesignPattern.RealWorld

# Iterator - Structural
dotnet run --project HEG.IteratorDesignPattern.Structural

# Iterator - Real World
dotnet run --project HEG.IteratorDesignPattern.RealWorld

# Mediator - Structural
dotnet run --project HEG.MediatorDesignPattern.Structural

# Mediator - Real World
dotnet run --project HEG.MediatorDesignPattern.RealWorld

# Memento - Structural
dotnet run --project HEG.MementoDesignPattern.Structural

# Memento - Real World
dotnet run --project HEG.MementoDesignPattern.RealWorld

# Observer - Structural
dotnet run --project HEG.ObserverDesignPattern.Structural

# Observer - Real World
dotnet run --project HEG.ObserverDesignPattern.RealWorld

# State - Structural
dotnet run --project HEG.StateDesignPattern.Structural

# State - Real World
dotnet run --project HEG.StateDesignPattern.RealWorld

# Strategy - Structural
dotnet run --project HEG.StrategyDesignPattern.Structural

# Strategy - Real World
dotnet run --project HEG.StrategyDesignPattern.RealWorld

# Template Method - Structural
dotnet run --project HEG.TemplateMethodDesignPattern.Structural

# Template Method - Real World
dotnet run --project HEG.TemplateMethodDesignPattern.RealWorld

# Visitor - Structural
dotnet run --project HEG.VisitorDesignPattern.Structural

# Visitor - Real World
dotnet run --project HEG.VisitorDesignPattern.RealWorld

```
## 📁 Project Structure

```
designPattern/
├── HEG.AbstractFactoryDesignPattern.Structural/   # Abstract Factory structural example
├── HEG.AbstractFactoryDesignPattern.RealWorld/    # Abstract Factory real-world example
├── HEG.BuilderDesignPattern.Structural/   # Builder structural example
├── HEG.BuilderDesignPattern.RealWorld/    # Builder real-world example
├── HEG.FactoryMethodDesignPattern.Structural/   # Factory Method structural example
├── HEG.FactoryMethodDesignPattern.RealWorld/    # Factory Method real-world example
├── HEG.PrototypeDesignPattern.Structural/   # Prototype structural example
├── HEG.PrototypeDesignPattern.RealWorld/    # Prototype real-world example
├── HEG.SingletonDesignPattern.Structural/   # Singleton structural example
├── HEG.SingletonDesignPattern.RealWorld/    # Singleton real-world example
├── HEG.AdapterDesignPattern.Structural/   # Adapter structural example
├── HEG.AdapterDesignPattern.RealWorld/    # Adapter real-world example
├── HEG.BridgeDesignPattern.Structural/   # Bridge structural example
├── HEG.BridgeDesignPattern.RealWorld/    # Bridge real-world example
├── HEG.CompositeDesignPattern.Structural/   # Composite structural example
├── HEG.CompositeDesignPattern.RealWorld/    # Composite real-world example
├── HEG.DecoratorDesignPattern.Structural/   # Decorator structural example
├── HEG.DecoratorDesignPattern.RealWorld/    # Decorator real-world example
├── HEG.FacadeDesignPattern.Structural/   # Facade structural example
├── HEG.FacadeDesignPattern.RealWorld/    # Facade real-world example
├── HEG.FlyweightDesignPattern.Structural/   # Flyweight structural example
├── HEG.FlyweightDesignPattern.RealWorld/    # Flyweight real-world example
├── HEG.ProxyDesignPattern.Structural/   # Proxy structural example
├── HEG.ProxyDesignPattern.RealWorld/    # Proxy real-world example
├── HEG.ChainOfResponsibilityDesignPattern.Structural/   # Chain of Responsibility structural example
├── HEG.ChainOfResponsibilityDesignPattern.RealWorld/    # Chain of Responsibility real-world example
├── HEG.CommandDesignPattern.Structural/   # Command structural example
├── HEG.CommandDesignPattern.RealWorld/    # Command real-world example
├── HEG.InterpreterDesignPattern.Structural/   # Interpreter structural example
├── HEG.InterpreterDesignPattern.RealWorld/    # Interpreter real-world example
├── HEG.IteratorDesignPattern.Structural/   # Iterator structural example
├── HEG.IteratorDesignPattern.RealWorld/    # Iterator real-world example
├── HEG.MediatorDesignPattern.Structural/   # Mediator structural example
├── HEG.MediatorDesignPattern.RealWorld/    # Mediator real-world example
├── HEG.MementoDesignPattern.Structural/   # Memento structural example
├── HEG.MementoDesignPattern.RealWorld/    # Memento real-world example
├── HEG.ObserverDesignPattern.Structural/   # Observer structural example
├── HEG.ObserverDesignPattern.RealWorld/    # Observer real-world example
├── HEG.StateDesignPattern.Structural/   # State structural example
├── HEG.StateDesignPattern.RealWorld/    # State real-world example
├── HEG.StrategyDesignPattern.Structural/   # Strategy structural example
├── HEG.StrategyDesignPattern.RealWorld/    # Strategy real-world example
├── HEG.TemplateMethodDesignPattern.Structural/   # Template Method structural example
├── HEG.TemplateMethodDesignPattern.RealWorld/    # Template Method real-world example
├── HEG.VisitorDesignPattern.Structural/   # Visitor structural example
├── HEG.VisitorDesignPattern.RealWorld/    # Visitor real-world example
├── docs/
│   ├── AbstractFactory.md
│   ├── Builder.md
│   ├── FactoryMethod.md
│   ├── Prototype.md
│   ├── Singleton.md
│   ├── Adapter.md
│   ├── Bridge.md
│   ├── Composite.md
│   ├── Decorator.md
│   ├── Facade.md
│   ├── Flyweight.md
│   ├── Proxy.md
│   ├── ChainOfResponsibility.md
│   ├── Command.md
│   ├── Interpreter.md
│   ├── Iterator.md
│   ├── Mediator.md
│   ├── Memento.md
│   ├── Observer.md
│   ├── State.md
│   ├── Strategy.md
│   ├── TemplateMethod.md
│   └── Visitor.md
└── HEG.DesignPattern.sln
```
## 📖 Pattern Documentation

- [Abstract Factory Pattern](./docs/AbstractFactory.md)
- [Builder Pattern](./docs/Builder.md)
- [Factory Method Pattern](./docs/FactoryMethod.md)
- [Prototype Pattern](./docs/Prototype.md)
- [Singleton Pattern](./docs/Singleton.md)
- [Adapter Pattern](./docs/Adapter.md)
- [Bridge Pattern](./docs/Bridge.md)
- [Composite Pattern](./docs/Composite.md)
- [Decorator Pattern](./docs/Decorator.md)
- [Facade Pattern](./docs/Facade.md)
- [Flyweight Pattern](./docs/Flyweight.md)
- [Proxy Pattern](./docs/Proxy.md)
- [Chain of Responsibility Pattern](./docs/ChainOfResponsibility.md)
- [Command Pattern](./docs/Command.md)
- [Interpreter Pattern](./docs/Interpreter.md)
- [Iterator Pattern](./docs/Iterator.md)
- [Mediator Pattern](./docs/Mediator.md)
- [Memento Pattern](./docs/Memento.md)
- [Observer Pattern](./docs/Observer.md)
- [State Pattern](./docs/State.md)
- [Strategy Pattern](./docs/Strategy.md)
- [Template Method Pattern](./docs/TemplateMethod.md)
- [Visitor Pattern](./docs/Visitor.md)

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
