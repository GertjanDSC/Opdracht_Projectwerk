﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Exceptions
{
    public class BestuurderManagerException : Exception
    {
        public BestuurderManagerException(string message) : base(message)
        {
        }

        public BestuurderManagerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
