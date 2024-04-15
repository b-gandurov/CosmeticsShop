using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Exceptions
{
    public class InvalidUserInputException : Exception
    {
        public InvalidUserInputException(string message)
            : base(message)
        {
        }
    }
}
