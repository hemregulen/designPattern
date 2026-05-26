namespace HEG.CommandDesignPattern.RealWorld.Command
{
    public interface IUndoableCommand
    {
        void Execute();
        void Undo();
    }

    public class TextEditor
    {
        public string Content { get; private set; } = string.Empty;

        public void Insert(int position, string text)
        {
            Content = Content.Insert(position, text);
        }

        public string Delete(int position, int length)
        {
            string removed = Content.Substring(position, length);
            Content = Content.Remove(position, length);
            return removed;
        }
    }

    public class InsertTextCommand : IUndoableCommand
    {
        private readonly TextEditor _editor;
        private readonly int _position;
        private readonly string _text;

        public InsertTextCommand(TextEditor editor, int position, string text)
        {
            _editor = editor;
            _position = position;
            _text = text;
        }

        public void Execute() => _editor.Insert(_position, _text);

        public void Undo() => _editor.Delete(_position, _text.Length);
    }

    public class DeleteTextCommand : IUndoableCommand
    {
        private readonly TextEditor _editor;
        private readonly int _position;
        private readonly int _length;
        private string _deletedText = string.Empty;

        public DeleteTextCommand(TextEditor editor, int position, int length)
        {
            _editor = editor;
            _position = position;
            _length = length;
        }

        public void Execute()
        {
            _deletedText = _editor.Delete(_position, _length);
        }

        public void Undo()
        {
            _editor.Insert(_position, _deletedText);
        }
    }

    public class CommandManager
    {
        private readonly Stack<IUndoableCommand> _undoStack = new();
        private readonly Stack<IUndoableCommand> _redoStack = new();

        public void ExecuteCommand(IUndoableCommand command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_undoStack.TryPop(out IUndoableCommand? command))
            {
                command.Undo();
                _redoStack.Push(command);
            }
        }

        public void Redo()
        {
            if (_redoStack.TryPop(out IUndoableCommand? command))
            {
                command.Execute();
                _undoStack.Push(command);
            }
        }
    }
}
