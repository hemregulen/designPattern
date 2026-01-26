using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.AbstractFactoryDesignPattern.RealWorld.Document
{
    public abstract class DocumentFactory
    {
        public abstract IPage CreatePage();
        public abstract ISection CreateSection();
    }
}
