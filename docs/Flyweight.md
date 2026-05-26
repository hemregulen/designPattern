# Flyweight Design Pattern

## Intent
Share common intrinsic state across many objects to reduce memory usage.

## Problem
Large numbers of fine-grained objects can consume too much memory when each one stores duplicate state.

## Solution
Flyweight separates shared intrinsic state from unique extrinsic state and centralizes shared instances in a factory.

## Structure

```
Flyweight
    └── Operation(extrinsicState)

ConcreteFlyweight
    └── intrinsicState

FlyweightFactory
    └── cache of shared flyweights
```

## Implementation

### Structural Example
Location: `HEG.FlyweightDesignPattern.Structural`

This example demonstrates the basic structure of the Flyweight pattern:
- ConcreteFlyweight stores intrinsic state only.
- Clients pass extrinsic state into operations.
- FlyweightFactory reuses previously created flyweights by key.

### Real-World Example
Location: `HEG.FlyweightDesignPattern.RealWorld`

This example demonstrates a practical use of the Flyweight pattern:
- CharacterStyle objects are shared flyweights.
- CharacterGlyph instances keep unique symbol positions.
- CharacterStyleFactory ensures identical styles are reused across a document.

## When to Use

- Many small objects share repeated state.
- Memory pressure matters.
- Shared state can be cleanly separated from unique state.

## Advantages

- Reduces memory usage significantly.
- Centralizes sharing logic.
- Works well for repeated immutable state.

## Disadvantages

- Requires careful separation of intrinsic and extrinsic state.
- May increase runtime complexity.

## Related Patterns

- **Composite**
- **Factory Method**
- **Singleton**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.FlyweightDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.FlyweightDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.FlyweightDesignPattern.Structural.Flyweight;

FlyweightFactory factory = new();
Flyweight first = factory.GetFlyweight("X");
Flyweight second = factory.GetFlyweight("Y");
Flyweight reused = factory.GetFlyweight("X");

first.Operation("first call");
second.Operation("second call");
reused.Operation("reused call");
Console.WriteLine($"Flyweights created: {factory.Count}");
```
