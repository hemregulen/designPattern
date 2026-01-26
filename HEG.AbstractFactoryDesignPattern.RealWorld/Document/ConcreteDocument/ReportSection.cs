using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.AbstractFactoryDesignPattern.RealWorld.Document.ConcreteDocument
{
    public class ReportSection : ISection
    {
        private List<string> items = new List<string>();

        public void Add(string content)
        {
            items.Add(content);
        }

        public void Display()
        {
            Console.WriteLine("Report Section:");
            int counter = 1;
            foreach (var item in items)
            {
                Console.WriteLine($"  {counter}. {item}");
                counter++;
            }
        }
    }
}
