using HEG.ObserverDesignPattern.Structural.Observer;

ConcreteSubject subject = new();
subject.Subscribe(new ConcreteObserver("Observer A"));
subject.Subscribe(new ConcreteObserver("Observer B"));
subject.State = "Updated state";
subject.Notify();
