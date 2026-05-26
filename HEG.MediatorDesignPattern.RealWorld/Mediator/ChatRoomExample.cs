namespace HEG.MediatorDesignPattern.RealWorld.Mediator
{
    public interface IChatRoom
    {
        void ShowMessage(User sender, string message);
    }

    public class ChatRoom : IChatRoom
    {
        private readonly List<User> _users = new();

        public void Register(User user)
        {
            _users.Add(user);
        }

        public void ShowMessage(User sender, string message)
        {
            foreach (User user in _users.Where(user => user != sender))
            {
                user.Receive(sender.Name, message);
            }
        }
    }

    public class User
    {
        private readonly IChatRoom _chatRoom;

        public User(string name, IChatRoom chatRoom)
        {
            Name = name;
            _chatRoom = chatRoom;
        }

        public string Name { get; }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _chatRoom.ShowMessage(this, message);
        }

        public void Receive(string sender, string message)
        {
            Console.WriteLine($"{Name} receives from {sender}: {message}");
        }
    }
}
