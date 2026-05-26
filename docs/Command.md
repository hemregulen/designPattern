# Command Design Pattern

## Intent
Encapsulate a request as an object so it can be queued, logged, undone, or parameterized.

## Problem
Direct method calls tightly couple the invoker to receiver logic and make undo, replay, or queuing difficult.

## Solution
Command moves each action into its own object, letting invokers trigger work without knowing implementation details.

## Structure

```
Invoker
    └── Execute command

ICommand
    └── Execute()

ConcreteCommand
    └── Receiver
```

## Implementation

### Structural Example
Location: `HEG.CommandDesignPattern.Structural`

This example demonstrates the basic structure of the Command pattern:
- Invoker stores a command object.
- ConcreteCommand delegates real work to Receiver.
- Receiver contains the business action.

### Real-World Example
Location: `HEG.CommandDesignPattern.RealWorld`

This example demonstrates a practical use of the Command pattern:
- TextEditor is the receiver.
- InsertTextCommand and DeleteTextCommand encapsulate editing operations.
- CommandManager tracks undo and redo stacks.

## When to Use

- Actions should be decoupled from the object that triggers them.
- Undo/redo or history is required.
- Requests should be queued or replayed.

## Advantages

- Decouples invokers from receivers.
- Makes undo/redo straightforward.
- Supports composition, logging, and scheduling of actions.

## Disadvantages

- Creates additional command classes.
- Simple actions may feel overly abstracted.

## Related Patterns

- **Chain of Responsibility**
- **Memento**
- **Strategy**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.CommandDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.CommandDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.CommandDesignPattern.Structural.Command;

Receiver receiver = new();
Invoker invoker = new();
invoker.SetCommand(new ConcreteCommand(receiver));
invoker.Run();
```
