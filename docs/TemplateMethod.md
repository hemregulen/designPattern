# Template Method Design Pattern

## Intent
Define the skeleton of an algorithm in a base class while deferring specific steps to subclasses.

## Problem
Similar workflows are often duplicated across classes even though only a few steps vary.

## Solution
Template Method captures the shared algorithm once and uses abstract or virtual operations for the variable pieces.

## Structure

```
AbstractClass
    └── TemplateMethod()
         ├── PrimitiveOperation1()
         ├── PrimitiveOperation2()
         └── Hook()

ConcreteClass1 / ConcreteClass2
```

## Implementation

### Structural Example
Location: `HEG.TemplateMethodDesignPattern.Structural`

This example demonstrates the basic structure of the Template Method pattern:
- AbstractClass defines the invariant workflow.
- Concrete classes implement the varying primitive operations.
- Hooks allow optional customization points.

### Real-World Example
Location: `HEG.TemplateMethodDesignPattern.RealWorld`

This example demonstrates a practical use of the Template Method pattern:
- ReportGenerator defines the shared report generation sequence.
- HtmlReport and PdfReport customize the output details.
- The header/body/footer workflow remains consistent across report types.

## When to Use

- Several classes share the same high-level algorithm.
- Only certain steps vary by subtype.
- Workflow order must stay controlled by the base class.

## Advantages

- Removes duplicated workflow code.
- Keeps algorithm order consistent.
- Provides clear extension points.

## Disadvantages

- Depends on inheritance.
- Too many hooks can make base workflows harder to reason about.

## Related Patterns

- **Factory Method**
- **Strategy**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.TemplateMethodDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.TemplateMethodDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.TemplateMethodDesignPattern.Structural.TemplateMethod;

AbstractClass class1 = new ConcreteClass1();
AbstractClass class2 = new ConcreteClass2();

class1.TemplateMethod();
class2.TemplateMethod();
```
