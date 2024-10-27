using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.methods
{
    public static class Fibonacci
    {
        public static int[] FibonacciArray(int n) 
        {
            int[] fibonacci_array = new int[n];
            // (int, int) tuple = (0,  1);
            int firstNumber = 0;
            int secondNumber = 1;
            
            for (int i = 0; i < n; i++)
            {
                fibonacci_array[i] = firstNumber;
                if (firstNumber == 0) firstNumber = 1;
                else
                {
                    int temp = secondNumber;
                    secondNumber = firstNumber + secondNumber;
                    firstNumber = temp;
                }
            }

            return fibonacci_array;
        }
    }
}
