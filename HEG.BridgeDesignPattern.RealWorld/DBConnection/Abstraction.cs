using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.BridgeDesignPattern.RealWorld.DBConnection
{
    public class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor
        {
            set { implementor = value; }
        }
        public virtual string Operation()
        {
            return implementor.ConnectionString();
        }
    }
}
