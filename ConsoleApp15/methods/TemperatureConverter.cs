using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    internal class TemperatureConverter
    {
        public static int Convert(int temperature)
        {
            return (temperature * 9/5 + 32);
        }
    }
}
