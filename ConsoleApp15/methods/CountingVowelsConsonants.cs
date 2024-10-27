using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    internal class CountingVowelsConsonants
    {
        public static (int, int) Counting(string line)
        {
            string vowels = "аеёиоуыэюяaeiouy";
            string consonants = "бвгджзйклмнпрстфхцчшщbcdfghjklmnpqrstvwxz";
            int a = 0, b = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (vowels.Contains(line.ToLower()[i])) a++;
                else if (consonants.Contains(line.ToLower()[i])) b++;
            }

            return (a, b);
        }
    }
}
