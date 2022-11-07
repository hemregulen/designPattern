using HEG.BridgeDesignPattern.RealWorld.DBConnection;
using HEG.BridgeDesignPattern.RealWorld.DBConnection.DBImplementor;

Abstraction ab = new RefinedAbstraction();

ab.Implementor = new NPGSQL01();
Console.WriteLine(ab.Operation());

ab.Implementor = new SQLDB02();
Console.WriteLine(ab.Operation());

Console.ReadKey();