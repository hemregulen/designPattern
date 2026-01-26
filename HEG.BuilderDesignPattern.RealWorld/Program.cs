using HEG.BuilderDesignPattern.RealWorld.Computer;
using HEG.BuilderDesignPattern.RealWorld.Computer.ConcreteBuilder;

ComputerDirector director = new ComputerDirector();

Console.WriteLine("Building Gaming Computer...");
ComputerBuilder gamingBuilder = new GamingComputerBuilder();
director.ConstructComputer(gamingBuilder);
Computer gamingComputer = gamingBuilder.GetComputer();
gamingComputer.Show();

Console.WriteLine("\n\nBuilding Office Computer...");
ComputerBuilder officeBuilder = new OfficeComputerBuilder();
director.ConstructComputer(officeBuilder);
Computer officeComputer = officeBuilder.GetComputer();
officeComputer.Show();

Console.ReadKey();
