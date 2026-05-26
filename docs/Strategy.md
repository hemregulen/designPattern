# Strategy Design Pattern

## Intent
Encapsulate interchangeable algorithms behind a common interface.

## Problem
Embedding multiple algorithms in one class creates complex branching and makes it hard to extend or test individual approaches.

## Solution
Strategy isolates each algorithm in its own class so clients can swap behavior at runtime.

## Structure

```
Context
    └── has Strategy

IStrategy
ConcreteStrategyA / ConcreteStrategyB
```

## Implementation

### Structural Example
Location: `HEG.StrategyDesignPattern.Structural`

This example demonstrates the basic structure of the Strategy pattern:
- Context holds a strategy instance.
- Concrete strategies implement alternative algorithms.
- The active strategy can be changed without modifying the caller.

### Real-World Example
Location: `HEG.StrategyDesignPattern.RealWorld`

This example demonstrates a practical use of the Strategy pattern:
- Sorter delegates to an ISortStrategy.
- BubbleSortStrategy, QuickSortStrategy, and MergeSortStrategy each implement a sorting algorithm.
- Clients switch sorting behavior at runtime.

## When to Use

- Several algorithms solve the same problem.
- The best algorithm depends on runtime conditions.
- Algorithms should be tested and extended independently.

## Advantages

- Eliminates large conditional algorithm selection.
- Encapsulates algorithms cleanly.
- Allows runtime swapping of behavior.

## Disadvantages

- Clients must understand which strategy to choose.
- Adds more classes for small algorithm sets.

## Related Patterns

- **State**
- **Template Method**
- **Command**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.StrategyDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.StrategyDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.StrategyDesignPattern.Structural.Strategy;

Context context = new(new ConcreteStrategyA());
context.ExecuteStrategy(new[] { "delta", "alpha", "charlie" });
context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy(new[] { "delta", "alpha", "charlie" });
```
