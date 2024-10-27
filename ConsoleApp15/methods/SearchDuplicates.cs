using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    internal class SearchDuplicates
    {
        public static int Search(int[] array)
        {
            int count = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    count++;
                    while (i < array.Length - 1 && array[i] == array[i + 1])
                    {
                        i++;
                    }
                }
            }

            return count;
        }
    }
}
