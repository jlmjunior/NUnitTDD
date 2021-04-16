using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTDD
{
    public class Calculator
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        // Purposeful failure
        public int Multiply(int num1, int num2)
        {
            // return num1 * num2;
            return num1 + num2;
        }
    }
}
