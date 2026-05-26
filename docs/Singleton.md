# Singleton Design Pattern

## Intent
Ensure a class has exactly one instance and provide a controlled global access point.

## Problem
Some services, such as shared configuration or logging, should be globally available but still protected from accidental multiple instantiation.

## Solution
Singleton uses a private constructor and a shared static access point so all callers reuse the same instance.

## Structure

```
Singleton
    ├── private constructor
    └── static Instance
```

## Implementation

### Structural Example
Location: `HEG.SingletonDesignPattern.Structural`

This example demonstrates the basic structure of the Singleton pattern:
- Singleton uses Lazy<T> for thread-safe lazy initialization.
- The constructor is private so no external code can instantiate the class.
- All callers use the same Instance property.

### Real-World Example
Location: `HEG.SingletonDesignPattern.RealWorld`

This example demonstrates a practical use of the Singleton pattern:
- AppConfiguration stores shared key-value settings.
- The singleton instance is reused everywhere configuration is needed.
- The example shows values written once and read from another reference.

## When to Use

- Exactly one shared instance is required.
- A resource should be globally reachable with controlled creation.
- Initialization should happen lazily.

## Advantages

- Guarantees a single shared instance.
- Centralizes access to global services.
- Can delay creation until first use.

## Disadvantages

- Global state can make testing harder.
- Overuse can hide dependencies between classes.

## Related Patterns

- **Facade**
- **Factory Method**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.SingletonDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.SingletonDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.SingletonDesignPattern.Structural.Singleton;

Singleton first = Singleton.Instance;
Singleton second = Singleton.Instance;

Console.WriteLine(first.Operation());
Console.WriteLine($"Same instance: {ReferenceEquals(first, second)}");
```
