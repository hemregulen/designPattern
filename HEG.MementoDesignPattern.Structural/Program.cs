using HEG.MementoDesignPattern.Structural.Memento;

Originator originator = new() { State = "State #1" };
Caretaker caretaker = new();
caretaker.Add(originator.CreateMemento());

originator.State = "State #2";
caretaker.Add(originator.CreateMemento());
originator.State = "State #3";

originator.SetMemento(caretaker.Get(0));
Console.WriteLine($"Restored state: {originator.State}");
