﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.BridgeDesignPattern.RealWorld.DBConnection.DBImplementor
{
    public class AzureSynapse : Implementor
    {
        public override string ConnectionString()
        {
            return @"Data Source=localhost;Initial Catalog=AzureSynapse;Persist Security Info=True;User ID=username;Password=password;";
        }
    }
}
