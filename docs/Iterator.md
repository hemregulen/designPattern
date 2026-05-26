# Iterator Design Pattern

## Intent
Provide a standard way to traverse an aggregate without exposing its internal representation.

## Problem
Collections often need multiple traversal strategies, but exposing their internal storage leaks implementation details and couples clients to data structures.

## Solution
Iterator packages traversal state into a dedicated object so the aggregate controls storage while clients use a stable navigation API.

## Structure

```
IAggregate
    └── CreateIterator()

IIterator
    ├── First()
    ├── Next()
    └── CurrentItem
```

## Implementation

### Structural Example
Location: `HEG.IteratorDesignPattern.Structural`

This example demonstrates the basic structure of the Iterator pattern:
- ConcreteAggregate stores the underlying items.
- ConcreteIterator keeps the current position.
- Client code walks the collection through iterator methods instead of indexes.

### Real-World Example
Location: `HEG.IteratorDesignPattern.RealWorld`

This example demonstrates a practical use of the Iterator pattern:
- BookCollection owns the data.
- BookIterator provides forward traversal.
- The client can list books without knowing how they are stored.

## When to Use

- Traversal logic should be independent of collection storage.
- Collections may need custom navigation.
- Client code should avoid direct indexing logic.

## Advantages

- Hides collection internals.
- Supports multiple traversal implementations.
- Keeps traversal logic reusable.

## Disadvantages

- Adds extra types for simple collections.
- Custom iterators may duplicate features already in the language runtime.

## Related Patterns

- **Composite**
- **Factory Method**
- **Visitor**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.IteratorDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.IteratorDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.IteratorDesignPattern.Structural.Iterator;

ConcreteAggregate aggregate = new();
aggregate[0] = "Item A";
aggregate[1] = "Item B";
aggregate[2] = "Item C";

IIterator iterator = aggregate.CreateIterator();
for (object first = iterator.First(); !iterator.IsDone; first = iterator.Next())
{
    Console.WriteLine(iterator.CurrentItem);
}
```
