using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services.Exceptions
{
    public class DbContextException : ApplicationException
    {
        public DbContextException(string message) : base(message)
        {
        }
    }
}
