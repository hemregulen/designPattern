using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.AbstractFactoryDesignPattern.RealWorld.Document.ConcreteDocument
{
    public class ResumeSection : ISection
    {
        private List<string> items = new List<string>();

        public void Add(string content)
        {
            items.Add(content);
        }

        public void Display()
        {
            Console.WriteLine("Resume Section:");
            foreach (var item in items)
            {
                Console.WriteLine($"  • {item}");
            }
        }
    }
}
