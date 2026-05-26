using HEG.IteratorDesignPattern.Structural.Iterator;

ConcreteAggregate aggregate = new();
aggregate[0] = "Item A";
aggregate[1] = "Item B";
aggregate[2] = "Item C";

IIterator iterator = aggregate.CreateIterator();
for (object first = iterator.First(); !iterator.IsDone; first = iterator.Next())
{
    Console.WriteLine(iterator.CurrentItem);
}
