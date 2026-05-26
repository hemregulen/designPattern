# Prototype Design Pattern

## Intent
Create new objects by cloning existing ones instead of constructing them from scratch.

## Problem
When object creation is expensive or when code should create copies without depending on concrete classes, constructors and large setup blocks become cumbersome.

## Solution
Prototype introduces a cloning operation so configured objects can duplicate themselves and serve as templates for new instances.

## Structure

```
Prototype
    └── Clone()

ConcretePrototype1 / ConcretePrototype2
    └── Clone() -> copy of itself
```

## Implementation

### Structural Example
Location: `HEG.PrototypeDesignPattern.Structural`

This example demonstrates the basic structure of the Prototype pattern:
- Prototype defines the cloning contract.
- Concrete prototypes use MemberwiseClone to duplicate their current state.
- Client code copies ready-made prototypes and customizes the clones.

### Real-World Example
Location: `HEG.PrototypeDesignPattern.RealWorld`

This example demonstrates a practical use of the Prototype pattern:
- Shape is the prototype abstraction.
- Circle and Rectangle clone themselves and keep their current dimensions and color.
- The client duplicates a shape and changes only the needed properties.

## When to Use

- Object initialization is costly or repetitive.
- Client code should create copies without depending on concrete types.
- New objects should start from an existing configured instance.

## Advantages

- Reduces repetitive setup code.
- Hides concrete class details from clients.
- Makes it easy to create configured variants.

## Disadvantages

- Deep copy logic can become tricky for complex graphs.
- Classes must support safe cloning semantics.

## Related Patterns

- **Factory Method**
- **Abstract Factory**
- **Builder**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.PrototypeDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.PrototypeDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.PrototypeDesignPattern.Structural.Prototype;

ConcretePrototype1 prototype1 = new(1, "Alpha");
ConcretePrototype1 clone1 = (ConcretePrototype1)prototype1.Clone();
clone1.Name = "Alpha Clone";

ConcretePrototype2 prototype2 = new(2, 99.9);
ConcretePrototype2 clone2 = (ConcretePrototype2)prototype2.Clone();
clone2.Value = 123.4;

Console.WriteLine($"Original: {prototype1.Id} - {prototype1.Name}");
Console.WriteLine($"Clone: {clone1.Id} - {clone1.Name}");
Console.WriteLine($"Original: {prototype2.Id} - {prototype2.Value}");
Console.WriteLine($"Clone: {clone2.Id} - {clone2.Value}");
```
