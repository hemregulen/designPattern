using HEG.MementoDesignPattern.RealWorld.Memento;

TextEditor editor = new();
TextHistory history = new();

editor.Type("Hello");
history.Push(editor.Save());
editor.Type(" Hello Patterns");
history.Push(editor.Save());
editor.Type("!");

editor.Restore(history.Pop());
Console.WriteLine(editor.Content);
