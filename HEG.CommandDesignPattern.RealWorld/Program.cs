using HEG.CommandDesignPattern.RealWorld.Command;

TextEditor editor = new();
CommandManager manager = new();

manager.ExecuteCommand(new InsertTextCommand(editor, 0, "Hello"));
manager.ExecuteCommand(new InsertTextCommand(editor, 5, " World"));
manager.ExecuteCommand(new DeleteTextCommand(editor, 5, 1));

Console.WriteLine($"Current text: {editor.Content}");
manager.Undo();
Console.WriteLine($"After undo: {editor.Content}");
manager.Redo();
Console.WriteLine($"After redo: {editor.Content}");
