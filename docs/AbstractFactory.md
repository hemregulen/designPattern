# Abstract Factory Design Pattern

## Intent
The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

## Problem
When you need to create objects that belong to multiple families or types, and you want to ensure that the created objects are compatible with each other, hardcoding the specific classes makes the code inflexible and difficult to maintain.

## Solution
Define an abstract factory interface that declares methods for creating abstract products. Concrete factory classes implement this interface to create concrete products. The client code uses the abstract factory interface, remaining independent of the concrete classes.

## Structure

```
AbstractFactory
    ├── CreateProductA()
    └── CreateProductB()

ConcreteFactory1 : AbstractFactory
    ├── CreateProductA() → ProductA1
    └── CreateProductB() → ProductB1

ConcreteFactory2 : AbstractFactory
    ├── CreateProductA() → ProductA2
    └── CreateProductB() → ProductB2
```

## Implementation

### Structural Example
Location: `HEG.AbstractFactoryDesignPattern.Structural`

This example demonstrates the basic structure of the Abstract Factory pattern:
- **AbstractFactory**: Declares methods for creating abstract products
- **ConcreteFactory1 & ConcreteFactory2**: Implement the factory interface to create concrete products
- **AbstractProductA & AbstractProductB**: Abstract product interfaces
- **ProductA1, ProductA2, ProductB1, ProductB2**: Concrete product implementations
- **Client**: Uses only abstract factory and product interfaces

### Real-World Example
Location: `HEG.AbstractFactoryDesignPattern.RealWorld`

A document management system that creates different types of documents (Resume, Report) with their associated pages and sections. Each document type requires compatible components that work together.

## When to Use

Use the Abstract Factory pattern when:
- Your system needs to be independent of how its objects are created
- You need to work with multiple families of related products
- You want to enforce that products from the same family are used together
- You want to provide a library of products that reveals only interfaces, not implementations

## Advantages

- **Isolates concrete classes**: Client code works with abstract interfaces
- **Makes exchanging product families easy**: Switch factories to change product families
- **Promotes consistency**: Ensures products from the same family work together
- **Supports Open/Closed Principle**: New product families can be added without changing existing code

## Disadvantages

- **Complexity**: Can be overkill for simple scenarios
- **Inflexibility**: Adding new product types requires changing the abstract factory interface

## Related Patterns

- **Factory Method**: Abstract Factory uses Factory Methods to create products
- **Singleton**: Factory objects are often implemented as Singletons
- **Prototype**: Factories can use Prototype to create products

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.AbstractFactoryDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.AbstractFactoryDesignPattern.RealWorld
```
