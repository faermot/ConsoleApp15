using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    internal class SumFromOneTo
    {
        public static int Sum(int number)
        {
            int sum = 0;

            for (int i = 0; i <= number; i++) sum += i;

            return sum;
        }
    }
}
