# Mediator Design Pattern

## Intent
Centralize communication between collaborating objects to reduce direct coupling.

## Problem
When many objects communicate directly, dependencies become tangled and coordination logic spreads across the entire object graph.

## Solution
Mediator introduces a central coordinator that knows how collaborators interact, letting colleagues stay simpler and more focused.

## Structure

```
Mediator
    └── Notify(sender, event)

Colleague1 / Colleague2
    └── communicate through mediator
```

## Implementation

### Structural Example
Location: `HEG.MediatorDesignPattern.Structural`

This example demonstrates the basic structure of the Mediator pattern:
- Colleagues know the mediator but not each other.
- ConcreteMediator contains the interaction rules.
- Messages are routed centrally instead of via direct dependencies.

### Real-World Example
Location: `HEG.MediatorDesignPattern.RealWorld`

This example demonstrates a practical use of the Mediator pattern:
- ChatRoom is the mediator.
- Users send messages to the room instead of directly to every other user.
- The chat room broadcasts incoming messages to participants.

## When to Use

- Many objects communicate in complex ways.
- Interaction rules should be centralized.
- Colleagues should stay reusable and loosely coupled.

## Advantages

- Reduces coupling between participants.
- Centralizes collaboration rules.
- Simplifies colleague classes.

## Disadvantages

- Mediator can become overly complex.
- Too much behavior may accumulate in one class.

## Related Patterns

- **Observer**
- **Facade**
- **Chain of Responsibility**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.MediatorDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.MediatorDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.MediatorDesignPattern.Structural.Mediator;

ConcreteColleague1 colleague1 = new();
ConcreteColleague2 colleague2 = new();
ConcreteMediator mediator = new(colleague1, colleague2);

colleague1.Send("Ping");
colleague2.Send("Pong");
```
