# Interpreter Design Pattern

## Intent
Represent grammar rules as objects that can interpret expressions in a language.

## Problem
Simple domain-specific languages or expression formats become scattered through parsing code when grammar rules are not modeled explicitly.

## Solution
Interpreter maps grammar elements to expression objects so complex statements are built from smaller interpretable parts.

## Structure

```
Context
IExpression
    └── Interpret()

TerminalExpression
NonterminalExpression
```

## Implementation

### Structural Example
Location: `HEG.InterpreterDesignPattern.Structural`

This example demonstrates the basic structure of the Interpreter pattern:
- Context stores the input to evaluate.
- TerminalExpression interprets primitive tokens.
- Nonterminal expressions combine other expressions into larger rules.

### Real-World Example
Location: `HEG.InterpreterDesignPattern.RealWorld`

This example demonstrates a practical use of the Interpreter pattern:
- Parser tokenizes a math expression.
- NumberExpression, AddExpression, and SubtractExpression represent the grammar.
- The parsed expression tree evaluates the final result.

## When to Use

- A small language or grammar must be interpreted repeatedly.
- Grammar rules should be explicit and composable.
- The language is simple enough to model with classes.

## Advantages

- Makes grammar rules explicit.
- Supports building expressions from reusable parts.
- Works well for small DSLs.

## Disadvantages

- Large grammars lead to many classes.
- Performance may not suit complex languages.

## Related Patterns

- **Composite**
- **Visitor**
- **Command**

## Running the Examples

```bash
# Run Structural Example
dotnet run --project HEG.InterpreterDesignPattern.Structural

# Run Real-World Example
dotnet run --project HEG.InterpreterDesignPattern.RealWorld
```

## Code Example

```csharp
using HEG.InterpreterDesignPattern.Structural.Interpreter;

Context context = new("design patterns in csharp");
IExpression expression = new OrExpression(new TerminalExpression("design"), new TerminalExpression("java"));

Console.WriteLine($"Expression result: {expression.Interpret(context)}");
```
