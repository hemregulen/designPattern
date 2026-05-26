# Adapter Design Pattern

## Intent
Convert one interface into another interface that client code expects.

## Problem
Useful existing classes often have incompatible interfaces, forcing client code to know implementation details or duplicate translation logic.

## Solution
Adapter wraps the incompatible object and translates requests between the expected target API and the adaptee.

## Structure

```
Target
    └── Request()

Adapter
    ├── has Adaptee
    └── Request() -> adaptee.SpecificRequest()

Adaptee
    └── SpecificRequest()
```

## Implementation

### Structural Example
Location: `HEG.AdapterDesignPattern.Structural`

This example demonstrates the basic structure of the Adapter pattern:
- Target represents the API clients understand.
- Adaptee exposes incompatible behavior.
- Adapter wraps Adaptee and translates the result into the target contract.

### Real-World Example
Location: `HEG.AdapterDesignPattern.RealWorld`

This example demonstrates a practical use of the Adapter pattern:
- IPrinter is the new interface expected by the application.
- LegacyPrinter still uses its older PrintLegacy method.
- PrinterAdapter bridges modern code to the legacy implementation.

## When to Use

- Existing classes are useful but expose the wrong interface.
- Migration work must keep old implementations alive.
- Translation should be isolated in one place.

## Advantages

- Reuses proven legacy code.
- Keeps interface translation out of business logic.
- Improves compatibility without changing old classes.

## Disadvantages

- Adds an extra layer of indirection.
- Too many adapters can complicate the design.

## Related Patterns

- **Bridge**
- **Decorator**
- **Facade**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.AdapterDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.AdapterDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.AdapterDesignPattern.Structural.Adapter;

Target target = new Adapter(new Adaptee());
Console.WriteLine(target.Request());
```
