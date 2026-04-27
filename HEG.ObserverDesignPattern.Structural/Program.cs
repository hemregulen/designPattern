using HEG.ObserverDesignPattern.Structural.Observer;
using HEG.ObserverDesignPattern.Structural.Observer.ConcreteObserver;
using HEG.ObserverDesignPattern.Structural.Observer.ConcreteSubject;

ConcreteSubject subject = new ConcreteSubject();

IObserver observer1 = new ConcreteObserver("Observer1");
IObserver observer2 = new ConcreteObserver("Observer2");
IObserver observer3 = new ConcreteObserver("Observer3");

subject.Attach(observer1);
subject.Attach(observer2);
subject.Attach(observer3);

Console.WriteLine("Setting state to 'StateA':");
subject.State = "StateA";

Console.WriteLine("\nDetaching Observer2...");
subject.Detach(observer2);

Console.WriteLine("\nSetting state to 'StateB':");
subject.State = "StateB";

Console.ReadKey();
