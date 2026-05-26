# State Design Pattern

## Intent
Represent states as objects so behavior changes with the current state.

## Problem
Large conditional blocks for mode-based behavior become hard to read and maintain as more states are added.

## Solution
State moves state-specific behavior into dedicated classes and lets the context delegate to the active state object.

## Structure

```
Context
    └── current State

IState
    └── Handle(context)

ConcreteStateA / ConcreteStateB
```

## Implementation

### Structural Example
Location: `HEG.StateDesignPattern.Structural`

This example demonstrates the basic structure of the State pattern:
- Context delegates work to the current state.
- Concrete states implement state-specific behavior.
- States can transition the context to other states.

### Real-World Example
Location: `HEG.StateDesignPattern.RealWorld`

This example demonstrates a practical use of the State pattern:
- TrafficLightContext holds the active light state.
- Red, Green, and Yellow states know the next transition.
- Behavior changes by swapping state objects instead of branching logic.

## When to Use

- Behavior varies heavily by current mode or status.
- Conditional logic around state is growing.
- Transitions should be explicit and encapsulated.

## Advantages

- Removes large conditional blocks.
- Keeps transitions explicit.
- Makes adding new states easier.

## Disadvantages

- Introduces more classes.
- State transitions can be harder to follow across files.

## Related Patterns

- **Strategy**
- **Memento**
- **Observer**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.StateDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.StateDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.StateDesignPattern.Structural.State;

Context context = new(new ConcreteStateA());
context.Request();
context.Request();
```
