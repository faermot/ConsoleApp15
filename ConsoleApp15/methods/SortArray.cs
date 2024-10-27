using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    internal class SortArray
    {
        public static int[] Selection(int[] array)
        {
            for (int i = 0; i < (array.Length - 1); i++)
            {
                int max = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[max])
                    {
                        max = j;
                    }
                }

                (array[max], array[i]) = (array[i], array[max]);
            }
            return array;
        }
    }
}
