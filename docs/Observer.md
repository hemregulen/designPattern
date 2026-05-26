# Observer Design Pattern

## Intent
Notify dependent objects automatically when subject state changes.

## Problem
Manually updating all dependent components leads to tight coupling and missed updates.

## Solution
Observer lets interested objects subscribe to a subject and receive notifications whenever relevant changes occur.

## Structure

```
Subject
    ├── Subscribe()
    ├── Unsubscribe()
    └── Notify()

Observer
    └── Update()
```

## Implementation

### Structural Example
Location: `HEG.ObserverDesignPattern.Structural`

This example demonstrates the basic structure of the Observer pattern:
- ConcreteSubject stores observer registrations.
- Observers expose a common update method.
- Notify broadcasts state changes to all subscribers.

### Real-World Example
Location: `HEG.ObserverDesignPattern.RealWorld`

This example demonstrates a practical use of the Observer pattern:
- WeatherStation is the subject.
- TemperatureDisplay and HumidityDisplay are observers.
- New measurements trigger automatic display updates.

## When to Use

- Multiple views depend on one source of truth.
- Publish/subscribe behavior is needed.
- Subjects should not know concrete dependent types.

## Advantages

- Reduces coupling between subject and dependents.
- Supports dynamic subscriptions.
- Works well for event-driven designs.

## Disadvantages

- Update order may matter.
- Many observers can make event flow harder to trace.

## Related Patterns

- **Mediator**
- **State**
- **Singleton**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.ObserverDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.ObserverDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.ObserverDesignPattern.Structural.Observer;

ConcreteSubject subject = new();
subject.Subscribe(new ConcreteObserver("Observer A"));
subject.Subscribe(new ConcreteObserver("Observer B"));
subject.State = "Updated state";
subject.Notify();
```
