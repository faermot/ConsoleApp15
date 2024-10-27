using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    internal class StringCompare
    {
        public static bool Compare(string firstLine, string secondLine)
        {
            string firstLineUpper = firstLine.ToUpper();
            string secondLineUpper = secondLine.ToUpper();

            if (firstLineUpper == secondLineUpper) return true;
            else return false;
        }
    }
}
