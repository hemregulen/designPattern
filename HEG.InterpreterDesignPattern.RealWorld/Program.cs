using HEG.InterpreterDesignPattern.RealWorld.Interpreter;

Parser parser = new("10 + 5 - 3 + 2");
IExpression expression = parser.Parse();

Console.WriteLine($"Result: {expression.Interpret()}");
