using HEG.AdapterDesignPattern.Structural.Adapter;

Target target = new Adapter(new Adaptee());
Console.WriteLine(target.Request());
