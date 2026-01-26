namespace HEG.BuilderDesignPattern.RealWorld.Computer
{
    public class Computer
    {
        public string? CPU { get; set; }
        public string? RAM { get; set; }
        public string? Storage { get; set; }
        public string? GraphicsCard { get; set; }
        public string? Motherboard { get; set; }
        public string? PowerSupply { get; set; }
        public string? Case { get; set; }

        public void Show()
        {
            Console.WriteLine("\n------ Computer Configuration ------");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
            Console.WriteLine($"Graphics Card: {GraphicsCard}");
            Console.WriteLine($"Motherboard: {Motherboard}");
            Console.WriteLine($"Power Supply: {PowerSupply}");
            Console.WriteLine($"Case: {Case}");
        }
    }
}
