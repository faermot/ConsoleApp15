using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    internal class ReverseArray
    {
        public static int[] Reverse(int[] array)
        {
            // array.Reverse();
            // return array;
            // Ну, через цикл так через цикл.
            int[] new_array = new int[array.Length];
            int count = 0;
            for (int i = (array.Length - 1); i >= 0; i--)
            {
                new_array[count] = array[i];
                count++;
            }

            return new_array;
        }
    }
}
