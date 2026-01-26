# Facade Design Pattern

## Intent
The Facade pattern provides a unified, simplified interface to a complex subsystem. It defines a higher-level interface that makes the subsystem easier to use by hiding its complexity.

## Problem
When working with complex libraries, frameworks, or subsystems with many interdependent classes, clients need to understand and interact with numerous components, making the code difficult to use and maintain.

## Solution
Create a Facade class that provides simple methods that delegate calls to the appropriate subsystem classes. The Facade handles the complexity and provides a clean, easy-to-use interface to clients.

## Structure

```
Facade
    ├── subsystem1: SubSystem1
    ├── subsystem2: SubSystem2
    ├── subsystem3: SubSystem3
    └── Operation()
         ├── subsystem1.Operation()
         ├── subsystem2.Operation()
         └── subsystem3.Operation()
```

## Implementation

### Structural Example
Location: `HEG.FacadeDesignPattern.Structural`

This example demonstrates the basic structure of the Facade pattern:
- **Facade**: Provides simplified methods for complex subsystem operations
- **SubSystemOne, SubSystemTwo, SubSystemThree, SubSystemFour**: Independent subsystem components
- Each subsystem handles a specific aspect of functionality

### Real-World Example
Location: `HEG.FacadeDesignPattern.RealWorld`

A washing machine control system that coordinates multiple subsystems:
- **WashingSystem**: Controls the washing mechanism
- **RinsingSystem**: Handles the rinsing process
- **SpinningSystem**: Manages the spinning cycle

The Facade provides simple methods like `Colors()` and `Blacks()` that:
1. Check weight capacity of all subsystems
2. Validate compatibility
3. Coordinate all systems to run the wash cycle

**Turkish Messages:**
- "Makine kontrol ediliyor" - Checking the machine
- "Ağırlık durulama sistemi için çok fazla" - Weight is too much for rinsing system
- "Ağırlık döndürme sistemi için çok fazla" - Weight is too much for spinning system
- "Ağırlık yıkama sistemi için çok fazla" - Weight is too much for washing system
- "Makineyi çalıştırmak için ağırlık tüm bileşenler için uygundur" - Weight is suitable for all components to run the machine

## When to Use

Use the Facade pattern when:
- You want to provide a simple interface to a complex subsystem
- There are many dependencies between clients and implementation classes
- You want to layer your subsystems (each layer has a facade)
- You need to decouple subsystems from clients and other subsystems

## Advantages

- **Simplification**: Makes the subsystem easier to use
- **Loose Coupling**: Reduces dependencies between subsystems and clients
- **Layering**: Helps in creating layers in the system
- **Flexibility**: Clients can still access subsystem classes directly if needed

## Disadvantages

- **God Object Risk**: Facade can become coupled to all subsystem classes
- **Limited Functionality**: May not expose all subsystem features
- **Additional Layer**: Adds another layer of indirection

## Related Patterns

- **Abstract Factory**: Can be used with Facade to provide an interface for creating subsystem objects
- **Mediator**: Similar in that it abstracts functionality, but Mediator facilitates communication between colleagues
- **Singleton**: Facade objects are often Singletons

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.FacadeDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.FacadeDesignPattern.RealWorld
```

## Code Example

```csharp
// Simple facade interface hides complex subsystem interactions
Facade facade = new Facade();

// Single method call coordinates multiple subsystems
facade.Colors(6); // Checks capacity and runs wash cycle for colored clothes
```
