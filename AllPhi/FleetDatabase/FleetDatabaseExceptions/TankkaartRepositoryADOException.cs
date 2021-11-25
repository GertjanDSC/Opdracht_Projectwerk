﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetDatabase.FleetDatabaseExceptions
{
    class TankkaartRepositoryADOException : Exception
    {
        public TankkaartRepositoryADOException(string message) : base(message)
        {
        }

        public TankkaartRepositoryADOException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
