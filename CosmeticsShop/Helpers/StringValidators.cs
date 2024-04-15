using CosmeticsShop.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Helpers
{
    public static class StringValidators
    {
        public static void StringLengthValidator(int minValue, int maxValue, string value, string message)
        {

            if (value.Length > maxValue || value.Length < minValue)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

    }
}
