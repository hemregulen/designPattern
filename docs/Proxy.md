# Proxy Design Pattern

## Intent
Provide a placeholder or surrogate that controls access to another object.

## Problem
Some objects are expensive, remote, sensitive, or should only be accessed under specific conditions.

## Solution
Proxy implements the same interface as the real subject and adds access control, lazy loading, caching, or logging around it.

## Structure

```
Subject
    └── Request()

RealSubject
Proxy
    └── has RealSubject
```

## Implementation

### Structural Example
Location: `HEG.ProxyDesignPattern.Structural`

This example demonstrates the basic structure of the Proxy pattern:
- Subject defines the common contract.
- Proxy checks access and delegates to the real subject.
- The real subject remains focused on the core work.

### Real-World Example
Location: `HEG.ProxyDesignPattern.RealWorld`

This example demonstrates a practical use of the Proxy pattern:
- IImage is shared by both proxy and real image.
- RealImage simulates expensive disk loading.
- ImageProxy delays loading until Display is called the first time.

## When to Use

- Objects are expensive to create or load.
- Access should be validated or logged.
- Remote or virtual access needs a local stand-in.

## Advantages

- Controls access transparently.
- Supports lazy loading and caching.
- Keeps client code unchanged.

## Disadvantages

- Adds one more layer in the call path.
- Proxy behavior can hide performance differences.

## Related Patterns

- **Adapter**
- **Decorator**
- **Facade**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.ProxyDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.ProxyDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.ProxyDesignPattern.Structural.Proxy;

ISubject subject = new ProxySubject();
subject.Request();
```
