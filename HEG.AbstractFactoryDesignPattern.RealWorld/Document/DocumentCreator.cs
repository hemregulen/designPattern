using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.AbstractFactoryDesignPattern.RealWorld.Document
{
    public class DocumentCreator
    {
        private IPage page;
        private ISection section;

        public DocumentCreator(DocumentFactory factory)
        {
            page = factory.CreatePage();
            section = factory.CreateSection();
        }

        public void CreateDocument(List<string> contents)
        {
            page.Display();
            foreach (var content in contents)
            {
                section.Add(content);
            }
            section.Display();
            Console.WriteLine();
        }
    }
}
