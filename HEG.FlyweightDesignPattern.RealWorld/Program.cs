using HEG.FlyweightDesignPattern.RealWorld.Flyweight;

CharacterStyleFactory factory = new();
TextDocument document = new();

document.AddCharacter('H', 0, 0, factory.GetStyle("Consolas", 14, "Black"));
document.AddCharacter('i', 1, 0, factory.GetStyle("Consolas", 14, "Black"));
document.AddCharacter('!', 2, 0, factory.GetStyle("Consolas", 14, "Red"));

document.Render();
Console.WriteLine($"Shared styles: {factory.Count}");
