# Bridge Design Pattern

## Intent
The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently. It separates the interface from the implementation, allowing both to change without affecting each other.

## Problem
When you have a class hierarchy that needs to be extended in multiple independent dimensions, inheritance can lead to an explosion of subclasses. For example, if you have shapes that need to support multiple rendering methods, creating a subclass for each combination (CircleWithVectorRenderer, CircleWithRasterRenderer, etc.) becomes unmanageable.

## Solution
Split the class hierarchy into two separate hierarchies: abstraction and implementation. The abstraction contains a reference to the implementation and delegates the actual work to it. Both hierarchies can then evolve independently.

## Structure

```
Abstraction
    ├── implementor: Implementor
    └── Operation()

RefinedAbstraction : Abstraction
    └── Operation()

Implementor
    └── OperationImpl()

ConcreteImplementorA : Implementor
    └── OperationImpl()

ConcreteImplementorB : Implementor
    └── OperationImpl()
```

## Implementation

### Structural Example
Location: `HEG.BridgeDesignPattern.Structural`

This example demonstrates the basic structure of the Bridge pattern:
- **Abstraction**: Defines the abstraction's interface and maintains a reference to an Implementor
- **RefinedAbstraction**: Extends the abstraction interface
- **Implementor**: Defines the interface for implementation classes
- **ConcreteImplementorA & ConcreteImplementorB**: Concrete implementations

### Real-World Example
Location: `HEG.BridgeDesignPattern.RealWorld`

A database connection system that decouples the database abstraction from specific database implementations. The same abstraction can work with different database systems (SQL Server, PostgreSQL, Azure Synapse) without modification.

**Key Components:**
- **Abstraction**: Base database connection abstraction
- **RefinedAbstraction**: Extended connection with additional features
- **Implementor**: Database connection interface
- **SQLDB01, SQLDB02, NPGSQL01, AzureSynapse**: Specific database implementations

## When to Use

Use the Bridge pattern when:
- You want to avoid permanent binding between abstraction and implementation
- Both abstraction and implementation need to be extensible by subclassing
- Changes in implementation should not impact clients
- You want to hide implementation details from clients
- You have a proliferation of classes resulting from multiple dimensions of variation

## Advantages

- **Decoupling**: Separates interface from implementation
- **Flexibility**: Both abstraction and implementation can vary independently
- **Extensibility**: New abstractions and implementations can be added without affecting each other
- **Platform Independence**: Implementation can be selected or switched at runtime

## Disadvantages

- **Complexity**: Increases the number of classes and complexity
- **Indirection**: May impact performance slightly due to extra layer

## Related Patterns

- **Adapter**: Bridges are designed up-front; Adapters are used to make unrelated classes work together
- **Abstract Factory**: Can create and configure a particular Bridge
- **Strategy**: Bridge allows changing implementation at runtime, like Strategy

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.BridgeDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.BridgeDesignPattern.RealWorld
```

## Code Example

```csharp
// Using different database implementations with the same abstraction
Abstraction connection = new RefinedAbstraction();

connection.Implementor = new NPGSQL01();
Console.WriteLine(connection.Operation()); // PostgreSQL connection string

connection.Implementor = new SQLDB02();
Console.WriteLine(connection.Operation()); // SQL Server connection string
```
