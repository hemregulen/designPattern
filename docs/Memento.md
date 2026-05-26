# Memento Design Pattern

## Intent
Capture object state externally so it can be restored later without breaking encapsulation.

## Problem
Undo or checkpoint features require previous state, but exposing internals directly violates encapsulation.

## Solution
Memento lets an originator create snapshots of its own state and later restore from them while caretakers manage the history.

## Structure

```
Originator
    ├── CreateMemento()
    └── SetMemento()

Memento
Caretaker
```

## Implementation

### Structural Example
Location: `HEG.MementoDesignPattern.Structural`

This example demonstrates the basic structure of the Memento pattern:
- Originator creates and restores mementos.
- Memento holds a snapshot of state.
- Caretaker stores snapshots without interpreting them.

### Real-World Example
Location: `HEG.MementoDesignPattern.RealWorld`

This example demonstrates a practical use of the Memento pattern:
- TextEditor is the originator.
- EditorMemento stores saved content.
- TextHistory maintains the undo stack.

## When to Use

- Undo, rollback, or checkpoints are needed.
- Object state should be restored later without exposing internals.
- History should be managed independently from the main object.

## Advantages

- Preserves encapsulation.
- Makes rollback straightforward.
- Separates history management from core behavior.

## Disadvantages

- Can consume memory for large histories.
- Snapshot frequency must be chosen carefully.

## Related Patterns

- **Command**
- **State**
- **Prototype**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.MementoDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.MementoDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.MementoDesignPattern.Structural.Memento;

Originator originator = new() { State = "State #1" };
Caretaker caretaker = new();
caretaker.Add(originator.CreateMemento());

originator.State = "State #2";
caretaker.Add(originator.CreateMemento());
originator.State = "State #3";

originator.SetMemento(caretaker.Get(0));
Console.WriteLine($"Restored state: {originator.State}");
```
