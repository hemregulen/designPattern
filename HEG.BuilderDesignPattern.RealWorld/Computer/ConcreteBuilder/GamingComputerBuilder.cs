namespace HEG.BuilderDesignPattern.RealWorld.Computer.ConcreteBuilder
{
    public class GamingComputerBuilder : ComputerBuilder
    {
        public override void BuildCPU()
        {
            computer.CPU = "Intel Core i9-13900K";
        }

        public override void BuildRAM()
        {
            computer.RAM = "32GB DDR5 6000MHz";
        }

        public override void BuildStorage()
        {
            computer.Storage = "2TB NVMe SSD";
        }

        public override void BuildGraphicsCard()
        {
            computer.GraphicsCard = "NVIDIA RTX 4090";
        }

        public override void BuildMotherboard()
        {
            computer.Motherboard = "ASUS ROG Maximus Z790";
        }

        public override void BuildPowerSupply()
        {
            computer.PowerSupply = "1000W 80+ Gold";
        }

        public override void BuildCase()
        {
            computer.Case = "Lian Li O11 Dynamic RGB";
        }
    }
}
