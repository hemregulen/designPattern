using HEG.CompositeDesignPattern.Structural.Composite;

Composite root = new("root");
root.Add(new Leaf("Leaf A"));
root.Add(new Leaf("Leaf B"));

Composite branch = new("Branch");
branch.Add(new Leaf("Leaf C"));
branch.Add(new Leaf("Leaf D"));
root.Add(branch);

root.Display(1);
