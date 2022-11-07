using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.BridgeDesignPattern.RealWorld.DBConnection.DBImplementor
{
    public class NPGSQL01 : Implementor
    {
        public override string ConnectionString()
        {
            return @"Data Source=localhost;Initial Catalog=NPGSQL01;Persist Security Info=True;User ID=username;Password=password;";
        }
    }
}
