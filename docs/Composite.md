# Composite Design Pattern

## Intent
Compose objects into tree structures so clients can treat individual objects and groups uniformly.

## Problem
Tree-like data such as folders, menus, and UI hierarchies is awkward to work with when leaves and containers require different client logic.

## Solution
Composite defines a shared component abstraction so leaves and composites can be used through the same interface.

## Structure

```
Component
    ├── Add()
    ├── Remove()
    └── Display()

Leaf
Composite
    └── children: List<Component>
```

## Implementation

### Structural Example
Location: `HEG.CompositeDesignPattern.Structural`

This example demonstrates the basic structure of the Composite pattern:
- Component defines the common API.
- Leaf implements terminal nodes.
- Composite stores child components and delegates traversal to them.

### Real-World Example
Location: `HEG.CompositeDesignPattern.RealWorld`

This example demonstrates a practical use of the Composite pattern:
- FileSystemItem is shared by files and folders.
- FileItem is a leaf and Folder is a composite.
- Folders display nested content and compute size recursively.

## When to Use

- You need part-whole hierarchies.
- Clients should treat single objects and groups consistently.
- Recursive traversal is common.

## Advantages

- Simplifies client code against hierarchical data.
- Makes recursive structures natural to model.
- Supports complex trees with uniform operations.

## Disadvantages

- Can make it harder to restrict which children are allowed.
- Generalized interfaces may expose operations some leaf types do not use.

## Related Patterns

- **Decorator**
- **Iterator**
- **Visitor**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.CompositeDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.CompositeDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.CompositeDesignPattern.Structural.Composite;

Composite root = new("root");
root.Add(new Leaf("Leaf A"));
root.Add(new Leaf("Leaf B"));

Composite branch = new("Branch");
branch.Add(new Leaf("Leaf C"));
branch.Add(new Leaf("Leaf D"));
root.Add(branch);

root.Display(1);
```
