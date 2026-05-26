# Chain of Responsibility Design Pattern

## Intent
Pass requests along a chain until an object chooses to handle them.

## Problem
When multiple handlers may process a request, coupling the sender to one concrete handler makes routing logic rigid and repetitive.

## Solution
Chain of Responsibility links handlers together so each one can handle the request or forward it onward.

## Structure

```
Handler
    ├── SetNext()
    └── Handle()

ConcreteHandler1 -> ConcreteHandler2 -> ConcreteHandler3
```

## Implementation

### Structural Example
Location: `HEG.ChainOfResponsibilityDesignPattern.Structural`

This example demonstrates the basic structure of the Chain of Responsibility pattern:
- Handler stores the next element in the chain.
- Concrete handlers decide whether to process or forward.
- The client builds the chain once and sends requests through the head.

### Real-World Example
Location: `HEG.ChainOfResponsibilityDesignPattern.RealWorld`

This example demonstrates a practical use of the Chain of Responsibility pattern:
- SupportHandler defines ticket escalation behavior.
- Level1Support, Level2Support, and Level3Support handle increasing ticket severity.
- Tickets move through the chain until the correct support level resolves them.

## When to Use

- Several objects may handle a request.
- Handler order matters.
- Request senders should not know the concrete receiver.

## Advantages

- Decouples senders from receivers.
- Makes chains easy to reorder or extend.
- Encapsulates routing decisions in handlers.

## Disadvantages

- Requests may go unhandled.
- Tracing the effective handler can be harder.

## Related Patterns

- **Command**
- **Composite**
- **Mediator**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.ChainOfResponsibilityDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.ChainOfResponsibilityDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.ChainOfResponsibilityDesignPattern.Structural.ChainOfResponsibility;

Handler handler = new ConcreteHandler1();
handler.SetNext(new ConcreteHandler2()).SetNext(new ConcreteHandler3());

foreach (int request in new[] { 5, 15, 25, 35 })
{
    Console.WriteLine($"Request {request}: {handler.Handle(request)}");
}
```
