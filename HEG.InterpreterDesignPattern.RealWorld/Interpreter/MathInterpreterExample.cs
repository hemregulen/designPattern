namespace HEG.InterpreterDesignPattern.RealWorld.Interpreter
{
    public interface IExpression
    {
        int Interpret();
    }

    public class NumberExpression : IExpression
    {
        public NumberExpression(int number)
        {
            Number = number;
        }

        public int Number { get; }
        public int Interpret() => Number;
    }

    public class AddExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public AddExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret() => _left.Interpret() + _right.Interpret();
    }

    public class SubtractExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public SubtractExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret() => _left.Interpret() - _right.Interpret();
    }

    public class Parser
    {
        private readonly string[] _tokens;

        public Parser(string expression)
        {
            _tokens = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

        public IExpression Parse()
        {
            IExpression current = new NumberExpression(int.Parse(_tokens[0]));

            for (int i = 1; i < _tokens.Length; i += 2)
            {
                string op = _tokens[i];
                IExpression next = new NumberExpression(int.Parse(_tokens[i + 1]));
                current = op switch
                {
                    "+" => new AddExpression(current, next),
                    "-" => new SubtractExpression(current, next),
                    _ => throw new InvalidOperationException($"Unsupported operator: {op}")
                };
            }

            return current;
        }
    }
}
