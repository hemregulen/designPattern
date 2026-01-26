# Builder Design Pattern

## Intent
The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

## Problem
When constructing a complex object with many optional components or configurations, using constructors with many parameters becomes unwieldy and error-prone. Creating multiple constructor overloads for different configurations leads to code duplication and maintenance issues.

## Solution
The Builder pattern provides a step-by-step approach to construct complex objects. It defines a separate Builder object that receives initialization parameters and builds the final object step by step, allowing for fine-grained control over the construction process.

## Structure

```
Director
    └── Construct(Builder)
         ├── builder.BuildPartA()
         ├── builder.BuildPartB()
         └── builder.BuildPartC()

Builder (abstract)
    ├── BuildPartA()
    ├── BuildPartB()
    ├── BuildPartC()
    └── GetResult()

ConcreteBuilder1
    ├── BuildPartA()
    ├── BuildPartB()
    ├── BuildPartC()
    └── GetResult() → Product1

ConcreteBuilder2
    ├── BuildPartA()
    ├── BuildPartB()
    ├── BuildPartC()
    └── GetResult() → Product2
```

## Implementation

### Structural Example
Location: `HEG.BuilderDesignPattern.Structural`

This example demonstrates the basic structure of the Builder pattern:
- **Builder**: Abstract class defining the interface for building parts
- **ConcreteBuilder1, ConcreteBuilder2**: Concrete builders that implement different ways to build the product
- **Product**: The complex object being built
- **Director**: Orchestrates the building process using a builder object

### Real-World Example
Location: `HEG.BuilderDesignPattern.RealWorld`

A computer assembly system that builds different types of computers:
- **Computer**: The complex product with multiple components (CPU, RAM, Storage, Graphics Card, etc.)
- **ComputerBuilder**: Abstract builder defining the interface for building computer components
- **GamingComputerBuilder**: Builds a high-performance gaming computer with:
  - Intel Core i9-13900K CPU
  - 32GB DDR5 RAM
  - NVIDIA RTX 4090 Graphics Card
  - 2TB NVMe SSD Storage
  - High-wattage power supply
  
- **OfficeComputerBuilder**: Builds a cost-effective office computer with:
  - Intel Core i5-12400 CPU
  - 16GB DDR4 RAM
  - Integrated Graphics
  - 512GB SATA SSD Storage
  - Standard power supply

- **ComputerDirector**: Orchestrates the step-by-step construction process

## When to Use

Use the Builder pattern when:
- You need to create complex objects with many optional components
- The algorithm for creating an object should be independent of the parts and their assembly
- The construction process must allow different representations of the constructed object
- You want to isolate complex construction code from the business logic

## Advantages

- **Flexibility**: Allows you to vary a product's internal representation
- **Construction Control**: Provides fine-grained control over the construction process
- **Code Reusability**: The same construction process can create different representations
- **Single Responsibility**: Isolates complex construction code from business logic
- **Readability**: Step-by-step construction makes the code more readable

## Disadvantages

- **Complexity**: Increases overall code complexity by creating multiple new classes
- **Overhead**: May be overkill for simple objects with few configuration options
- **Immutability**: Harder to implement with immutable objects

## Related Patterns

- **Abstract Factory**: Can be used together with Builder. Abstract Factory creates families of objects, while Builder constructs complex objects step by step
- **Composite**: Builder can construct composite trees
- **Prototype**: Builder and Prototype can be used together when you need to create variations of complex objects

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.BuilderDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.BuilderDesignPattern.RealWorld
```

## Code Example

```csharp
// Create director and builders
ComputerDirector director = new ComputerDirector();
ComputerBuilder gamingBuilder = new GamingComputerBuilder();

// Construct the computer step by step
director.ConstructComputer(gamingBuilder);

// Get the final product
Computer gamingComputer = gamingBuilder.GetComputer();
gamingComputer.Show();
```
