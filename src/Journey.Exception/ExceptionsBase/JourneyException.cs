using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey.Exception.ExceptionsBase
{
    public class JourneyException : System.Exception
    {
        //this will send the message to the ctor of System.Exception
        public JourneyException(string message) : base(message)
        {
            
        }
    }
}
