using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.AbstractFactoryDesignPattern.RealWorld.Document.ConcreteDocument
{
    public class ResumeFactory : DocumentFactory
    {
        public override IPage CreatePage()
        {
            return new ResumePage();
        }

        public override ISection CreateSection()
        {
            return new ResumeSection();
        }
    }
}
