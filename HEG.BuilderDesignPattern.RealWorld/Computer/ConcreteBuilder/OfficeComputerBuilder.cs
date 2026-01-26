namespace HEG.BuilderDesignPattern.RealWorld.Computer.ConcreteBuilder
{
    public class OfficeComputerBuilder : ComputerBuilder
    {
        public override void BuildCPU()
        {
            computer.CPU = "Intel Core i5-12400";
        }

        public override void BuildRAM()
        {
            computer.RAM = "16GB DDR4 3200MHz";
        }

        public override void BuildStorage()
        {
            computer.Storage = "512GB SATA SSD";
        }

        public override void BuildGraphicsCard()
        {
            computer.GraphicsCard = "Integrated Graphics";
        }

        public override void BuildMotherboard()
        {
            computer.Motherboard = "ASUS Prime B660M-A";
        }

        public override void BuildPowerSupply()
        {
            computer.PowerSupply = "450W 80+ Bronze";
        }

        public override void BuildCase()
        {
            computer.Case = "Fractal Design Define Mini";
        }
    }
}
