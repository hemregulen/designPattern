using HEG.CompositeDesignPattern.RealWorld.Composite;

Folder root = new("root");
root.Add(new FileItem("readme.txt", 8));

Folder documents = new("documents");
documents.Add(new FileItem("resume.pdf", 120));
documents.Add(new FileItem("invoice.xlsx", 64));

Folder photos = new("photos");
photos.Add(new FileItem("vacation.jpg", 512));

documents.Add(photos);
root.Add(documents);

root.Display(0);
Console.WriteLine($"Total size: {root.GetSize()} KB");
