using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.AbstractFactoryDesignPattern.RealWorld.Document.ConcreteDocument
{
    public class ReportPage : IPage
    {
        public void Display()
        {
            Console.WriteLine("Report Page - Formal format with page numbers and company header");
        }
    }
}
