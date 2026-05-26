# Factory Method Design Pattern

## Intent
Define an interface for creating objects while letting subclasses decide which concrete type to instantiate.

## Problem
When a base workflow must create products but the exact product varies by scenario, hard-coding concrete types makes the workflow rigid and hard to extend.

## Solution
Factory Method moves object creation into subclasses so the creator can keep common workflow logic while delegating which product gets created.

## Structure

```
Creator
    ├── FactoryMethod()
    └── SomeOperation()

ConcreteCreatorA / ConcreteCreatorB
    └── FactoryMethod() -> ConcreteProductA / ConcreteProductB

IProduct
    └── Operation()
```

## Implementation

### Structural Example
Location: `HEG.FactoryMethodDesignPattern.Structural`

This example demonstrates the basic structure of the Factory Method pattern:
- Creator defines the factory method and a workflow that uses the created product.
- ConcreteCreatorA and ConcreteCreatorB decide which product instance to create.
- ConcreteProductA and ConcreteProductB provide the concrete behavior.

### Real-World Example
Location: `HEG.FactoryMethodDesignPattern.RealWorld`

This example demonstrates a practical use of the Factory Method pattern:
- LogisticsCreator contains the delivery planning workflow.
- RoadLogistics creates Truck objects, and SeaLogistics creates Ship objects.
- The calling code works with the creator abstraction instead of concrete transport classes.

## When to Use

- A class cannot anticipate the exact type of object it must create.
- Common workflow should stay in a base class while products vary by subclass.
- New product variants should be introduced without changing client code.

## Advantages

- Removes direct coupling between workflow and concrete products.
- Supports open/closed extension with new creators and products.
- Keeps creation logic close to the variant that needs it.

## Disadvantages

- Adds more classes than direct instantiation.
- Can be overkill for very small creation variations.

## Related Patterns

- **Abstract Factory**
- **Prototype**
- **Template Method**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.FactoryMethodDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.FactoryMethodDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.FactoryMethodDesignPattern.Structural.FactoryMethod;

Creator creatorA = new ConcreteCreatorA();
Creator creatorB = new ConcreteCreatorB();

Console.WriteLine(creatorA.SomeOperation());
Console.WriteLine(creatorB.SomeOperation());
```
