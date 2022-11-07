using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.FacadeDesignPattern.RealWorld.WashingMachine.SubSystem
{
    public class WashingSystem
    {
        public bool WashingSystemControl(int weight)
        {
            if (weight > 6)
                return false;
            else
                return true;
        }
    }
}
