using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.AbstractFactoryDesignPattern.RealWorld.Document
{
    public interface ISection
    {
        void Add(string content);
        void Display();
    }
}
