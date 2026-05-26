namespace HEG.AdapterDesignPattern.Structural.Adapter
{
    public class Target
    {
        public virtual string Request() => "Target: default behavior";
    }

    public class Adaptee
    {
        public string SpecificRequest() => "eetpadA morf eulaV";
    }

    public class Adapter : Target
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public override string Request()
        {
            char[] array = _adaptee.SpecificRequest().ToCharArray();
            Array.Reverse(array);
            return $"Adapter translated: {new string(array)}";
        }
    }
}
