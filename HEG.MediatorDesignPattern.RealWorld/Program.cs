using HEG.MediatorDesignPattern.RealWorld.Mediator;

ChatRoom chatRoom = new();
User alice = new("Alice", chatRoom);
User bob = new("Bob", chatRoom);
User carol = new("Carol", chatRoom);

chatRoom.Register(alice);
chatRoom.Register(bob);
chatRoom.Register(carol);

alice.Send("Hello everyone!");
bob.Send("Hi Alice!");
