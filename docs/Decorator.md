# Decorator Design Pattern

## Intent
Attach additional responsibilities to objects dynamically without changing their core class.

## Problem
Subclassing every possible feature combination leads to an explosion of classes and rigid inheritance trees.

## Solution
Decorator wraps an existing component and adds behavior before or after delegating to it, allowing flexible runtime composition.

## Structure

```
Component
ConcreteComponent

Decorator
    └── has Component

ConcreteDecoratorA / ConcreteDecoratorB
    └── add behavior around Operation()
```

## Implementation

### Structural Example
Location: `HEG.DecoratorDesignPattern.Structural`

This example demonstrates the basic structure of the Decorator pattern:
- Component defines the common contract.
- ConcreteComponent provides the base behavior.
- Concrete decorators wrap a component and add extra behavior in layers.

### Real-World Example
Location: `HEG.DecoratorDesignPattern.RealWorld`

This example demonstrates a practical use of the Decorator pattern:
- SimpleCoffee is the base object.
- Milk, Sugar, and Whip decorate an existing coffee.
- Each decorator updates both description and price.

## When to Use

- Features should be mixed and matched at runtime.
- Subclass combinations would grow too large.
- Added behavior should stay optional and composable.

## Advantages

- Supports flexible runtime composition.
- Avoids subclass explosion.
- Keeps extensions small and reusable.

## Disadvantages

- Can create many small wrapper objects.
- Debugging nested decorators may be harder.

## Related Patterns

- **Adapter**
- **Composite**
- **Proxy**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.DecoratorDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.DecoratorDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.DecoratorDesignPattern.Structural.Decorator;

Component component = new ConcreteComponent();
Component decorated = new ConcreteDecoratorB(new ConcreteDecoratorA(component));

Console.WriteLine(component.Operation());
Console.WriteLine(decorated.Operation());
```
