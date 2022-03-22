using System;
using System.Collections.Generic;
using System.Text;

namespace Number_Range_Exeption
{
    public class NumberOutOfRangeExeption : Exception
    {
        public NumberOutOfRangeExeption()
        {
        }

        public NumberOutOfRangeExeption(string message)
            : base(message)
        {
        }

        public NumberOutOfRangeExeption(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
