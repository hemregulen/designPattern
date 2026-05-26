# Visitor Design Pattern

## Intent
Add new operations to object structures without modifying the element classes.

## Problem
When many unrelated operations must run across a fixed set of element types, putting all logic inside each element scatters responsibilities.

## Solution
Visitor externalizes operations into visitor objects while elements provide an accept entry point for double dispatch.

## Structure

```
Element
    └── Accept(visitor)

Visitor
    ├── VisitConcreteElementA()
    └── VisitConcreteElementB()

ConcreteElementA / ConcreteElementB
```

## Implementation

### Structural Example
Location: `HEG.VisitorDesignPattern.Structural`

This example demonstrates the basic structure of the Visitor pattern:
- Elements expose Accept for visitors.
- Visitors implement operations for each concrete element type.
- New visitors add new behavior without changing element classes.

### Real-World Example
Location: `HEG.VisitorDesignPattern.RealWorld`

This example demonstrates a practical use of the Visitor pattern:
- Circle and Rectangle are the visited shapes.
- AreaVisitor and PerimeterVisitor calculate different metrics.
- The same shapes can support new calculations by adding more visitors.

## When to Use

- Object structures are stable but operations change often.
- Different cross-cutting calculations should stay separate from element classes.
- Double dispatch is acceptable.

## Advantages

- Makes adding new operations easy.
- Keeps element classes focused on structure.
- Groups related operations together.

## Disadvantages

- Adding new element types affects all visitors.
- Double dispatch adds ceremony.

## Related Patterns

- **Composite**
- **Interpreter**
- **Iterator**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.VisitorDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.VisitorDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.VisitorDesignPattern.Structural.Visitor;

IElement[] elements = [new ConcreteElementA(), new ConcreteElementB()];
IVisitor visitor1 = new ConcreteVisitor1();
IVisitor visitor2 = new ConcreteVisitor2();

foreach (IElement element in elements)
{
    element.Accept(visitor1);
    element.Accept(visitor2);
}
```
