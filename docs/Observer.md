# Observer Design Pattern

## Intent
The Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

## Problem
When a change in one object requires changing others, and you don't know how many objects need to change, tightly coupling these objects leads to a fragile, hard-to-maintain system. The interested objects need a way to be informed of state changes without polling.

## Solution
The Observer pattern separates the **Subject** (the object being watched) from its **Observers** (the objects that react to changes). The Subject maintains a list of Observers and notifies them automatically whenever its state changes, keeping them loosely coupled.

## Structure

```
ISubject
    ├── Attach(IObserver)
    ├── Detach(IObserver)
    └── Notify()

ConcreteSubject
    ├── State (property)
    ├── Attach(IObserver)
    ├── Detach(IObserver)
    └── Notify() → calls Update() on all observers

IObserver
    └── Update(state)

ConcreteObserver
    └── Update(state) → reacts to the change
```

## Implementation

### Structural Example
Location: `HEG.ObserverDesignPattern.Structural`

This example demonstrates the core structure of the Observer pattern:
- **ISubject**: Interface defining Attach, Detach, and Notify methods
- **IObserver**: Interface defining the Update method
- **ConcreteSubject**: Holds state and notifies all registered observers on change
- **ConcreteObserver**: Receives and prints the updated state

### Real-World Example
Location: `HEG.ObserverDesignPattern.RealWorld`

A stock market tracking system where investors and alerts react to price changes:
- **Stock**: The subject that tracks a stock's price and notifies observers when it changes
- **IStockObserver**: Interface for objects that react to stock price changes
- **Investor**: Concrete observer that watches for buy opportunities when price drops below a threshold
- **StockAlert**: Concrete observer that triggers a high-price alert when price exceeds a threshold

## When to Use

Use the Observer pattern when:
- A change to one object requires changing others, and you don't know how many objects need to change
- An object should be able to notify other objects without making assumptions about who those objects are
- You want to implement distributed event-handling systems
- You need to decouple the source of events from the event handlers

## Advantages

- **Loose Coupling**: Subject and observers are loosely coupled; neither needs to know the details of the other
- **Open/Closed Principle**: You can add new observers without changing the subject
- **Dynamic Relationships**: Observers can be attached and detached at runtime
- **Broadcast Communication**: The subject notifies all registered observers in one call

## Disadvantages

- **Unexpected Updates**: Observers are notified in a non-deterministic order
- **Memory Leaks**: Forgotten observer registrations can prevent garbage collection
- **Performance**: Notifying many observers can be costly if the update logic is heavy

## Related Patterns

- **Mediator**: Can be used to centralize complex update logic between many subjects and observers
- **Singleton**: The subject is often a singleton to ensure all observers share the same state
- **Event-Driven**: Observer is the foundation of most event-driven and reactive programming models

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.ObserverDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.ObserverDesignPattern.RealWorld
```

## Code Example

```csharp
// Create subject (stock)
Stock appleStock = new Stock("AAPL", 175.00m);

// Create observers
Investor alice = new Investor("Alice", buyThreshold: 160.00m);
StockAlert highAlert = new StockAlert("High Price Alert", alertThreshold: 180.00m);

// Attach observers
appleStock.Attach(alice);
appleStock.Attach(highAlert);

// Trigger notifications by changing the price
appleStock.Price = 182.50m;  // Triggers highAlert
appleStock.Price = 158.00m;  // Triggers alice to buy
```
