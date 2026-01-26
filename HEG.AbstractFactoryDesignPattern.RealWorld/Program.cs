using HEG.AbstractFactoryDesignPattern.RealWorld.Document;
using HEG.AbstractFactoryDesignPattern.RealWorld.Document.ConcreteDocument;

// Create Resume
Console.WriteLine("=== Creating Resume ===");
DocumentFactory resumeFactory = new ResumeFactory();
DocumentCreator resumeCreator = new DocumentCreator(resumeFactory);

var resumeContent = new List<string>
{
    "Senior Software Engineer with 10+ years of experience",
    "Expert in C#, .NET, and design patterns",
    "Led teams of 5-10 developers on enterprise projects"
};

resumeCreator.CreateDocument(resumeContent);

// Create Report
Console.WriteLine("=== Creating Report ===");
DocumentFactory reportFactory = new ReportFactory();
DocumentCreator reportCreator = new DocumentCreator(reportFactory);

var reportContent = new List<string>
{
    "Q4 Financial Results show 15% growth",
    "New product launch exceeded expectations",
    "Customer satisfaction increased by 20%"
};

reportCreator.CreateDocument(reportContent);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
