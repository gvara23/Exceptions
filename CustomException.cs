using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class CustomException : Exception
    {
        public CustomException(string message) : base(message) 
        {
            ExceptionTime = DateTime.Now;
        }
        public DateTime ExceptionTime { get; private set; }
    }
}
