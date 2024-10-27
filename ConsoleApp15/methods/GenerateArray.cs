using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    internal class GenerateArray
    {
        public static int[] Generate(int size)
        {
            int[] array = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }

            return array;
        }
    }
}
