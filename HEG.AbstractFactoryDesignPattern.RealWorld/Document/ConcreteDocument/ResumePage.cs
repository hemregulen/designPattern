using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.AbstractFactoryDesignPattern.RealWorld.Document.ConcreteDocument
{
    public class ResumePage : IPage
    {
        public void Display()
        {
            Console.WriteLine("Resume Page - Professional format with contact info header");
        }
    }
}
