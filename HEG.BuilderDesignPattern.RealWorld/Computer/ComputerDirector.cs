namespace HEG.BuilderDesignPattern.RealWorld.Computer
{
    public class ComputerDirector
    {
        public void ConstructComputer(ComputerBuilder builder)
        {
            builder.BuildCPU();
            builder.BuildRAM();
            builder.BuildStorage();
            builder.BuildGraphicsCard();
            builder.BuildMotherboard();
            builder.BuildPowerSupply();
            builder.BuildCase();
        }
    }
}
