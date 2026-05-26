using HEG.FactoryMethodDesignPattern.RealWorld.FactoryMethod;

LogisticsCreator roadLogistics = new RoadLogistics();
LogisticsCreator seaLogistics = new SeaLogistics();

Console.WriteLine(roadLogistics.PlanDelivery());
Console.WriteLine(seaLogistics.PlanDelivery());
