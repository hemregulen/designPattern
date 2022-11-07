using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.BridgeDesignPattern.RealWorld.DBConnection
{
    public class RefinedAbstraction : Abstraction
    {
        public override string Operation()
        {
            return implementor.ConnectionString();
        }
    }
}
