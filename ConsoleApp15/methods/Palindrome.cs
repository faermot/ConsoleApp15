using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    internal class Palindrome
    {
        public static bool Check(string line)
        {
            string editedLine = line.Replace(" ", "").ToUpper();

            char[] lineArray = editedLine.ToCharArray();
            Array.Reverse(lineArray);
            string reversedLine = new string(lineArray);

            return editedLine == reversedLine;
        }
    }
}
