namespace HEG.InterpreterDesignPattern.Structural.Interpreter
{
    public class Context
    {
        public Context(string input)
        {
            Input = input;
        }

        public string Input { get; }
    }

    public interface IExpression
    {
        bool Interpret(Context context);
    }

    public class TerminalExpression : IExpression
    {
        private readonly string _token;

        public TerminalExpression(string token)
        {
            _token = token;
        }

        public bool Interpret(Context context)
        {
            return context.Input.Contains(_token, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class OrExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public OrExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public bool Interpret(Context context)
        {
            return _left.Interpret(context) || _right.Interpret(context);
        }
    }
}
