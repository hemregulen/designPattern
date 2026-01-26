namespace HEG.BuilderDesignPattern.RealWorld.Computer
{
    public abstract class ComputerBuilder
    {
        protected Computer computer = new Computer();

        public abstract void BuildCPU();
        public abstract void BuildRAM();
        public abstract void BuildStorage();
        public abstract void BuildGraphicsCard();
        public abstract void BuildMotherboard();
        public abstract void BuildPowerSupply();
        public abstract void BuildCase();

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
