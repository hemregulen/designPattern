using HEG.InterpreterDesignPattern.Structural.Interpreter;

Context context = new("design patterns in csharp");
IExpression expression = new OrExpression(new TerminalExpression("design"), new TerminalExpression("java"));

Console.WriteLine($"Expression result: {expression.Interpret(context)}");
