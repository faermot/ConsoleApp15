using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    public static class MinMaxArrayElements
    {
        public static (int, int) MinMax(int[] array)
        {
            int Max = array.Max();
            int Min = array.Min();
            return (Max, Min);
        }
    }
}
