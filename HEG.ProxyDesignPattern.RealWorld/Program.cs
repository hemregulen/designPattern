using HEG.ProxyDesignPattern.RealWorld.Proxy;

IImage image = new ImageProxy("architecture-diagram.png");
Console.WriteLine("Image created, not loaded yet.");
image.Display();
image.Display();
