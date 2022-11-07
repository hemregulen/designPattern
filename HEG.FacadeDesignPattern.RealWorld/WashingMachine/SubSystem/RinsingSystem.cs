using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.FacadeDesignPattern.RealWorld.WashingMachine.SubSystem
{
    public class RinsingSystem
    {
        public bool RinsingSystemControl(int weight)
        {
            if (weight>5)
                return false;
            else
                return true;
        }
    }
}
