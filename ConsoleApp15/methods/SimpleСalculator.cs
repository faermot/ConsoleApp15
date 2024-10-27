using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    internal class SimpleСalculator
    {
        public static float Сalculate(int a, int b, string operation)
        {
            float result = 0;

            if (operation == "+") result = a + b;
            else if (operation == "-") result = a - b;
            else if (operation == "*") result = a * b;
            else if (operation == "/") result = (float)a / b;

            return result;
        }
    }
}
