using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp15.methods;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Task39()
        {
            Console.Clear();
            Console.WriteLine("Задание 39");
            int[] array = new int[10];
            int SumEven = 0, SumOdd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Clear();
                Console.Write($"Введите число {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Произошла ошибка! Введите корректное число!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.Write($"Введите число {i + 1}: ");
                }
            }

            Console.Clear();
            Console.WriteLine($"Получившийся массив:");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
                if (item % 2 == 0) SumEven += item;
                if (item % 2 != 0) SumOdd += item;
            }

            Console.WriteLine($"\nСумма чётных чисел: {SumEven}");
            Console.WriteLine($"Сумма нечётных чисел: {SumOdd}");


            Console.ReadKey();

        }

        static void Task40()
        {
            Console.Clear();
            Console.WriteLine("Задание 40");
            Random rnd = new Random();
            int[] array = new int[10];

            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 51);
                Console.Write($"{array[i]} ");
            }
            (int max, int min) = methods.MinMaxArrayElements.MinMax(array);
            Console.WriteLine($"\nМаксимальный: {max}\nМинимальный: {min}");

            Console.ReadKey();
        }

        static void Task41()
        {
            Console.Clear();
            Console.WriteLine("Задание 41");
            int number;

            Console.Write($"Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Произошла ошибка! Введите корректное число!");
                Thread.Sleep(5000);
                Console.Clear();
                Console.Write($"Введите число: ");
            }


            Console.Clear();
            int[] array = new int[number];
            array = Fibonacci.FibonacciArray(number);
            Console.WriteLine($"Массив первых {number} чисел Фибоначчи: ");
            foreach (int item in array) Console.Write($"{item} ");

            Console.ReadKey();
        }

        static void Task42()
        {
            Console.Clear();
            Console.WriteLine("Задание 42");
            int[] array = new int[10];
            Random rnd = new Random();

            Console.WriteLine("\nНачальный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write($"{array[i]} ");
            }


            array = ReverseArray.Reverse(array);
            Console.WriteLine("\n\nИтоговый массив:");
            foreach (int item in array) Console.Write($"{item} ");

            Console.ReadKey();
        }

        static void Task43()
        {
            Console.Clear();
            Console.WriteLine("Задание 43");
            string firstLine, secondLine;
            bool result;

            Console.Write("Введите первую строку:");
            firstLine = Console.ReadLine();

            Console.Write("Введите вторую строку:");
            secondLine = Console.ReadLine();

            result = StringCompare.Compare(firstLine, secondLine);


            if (result) Console.WriteLine("Строки равны (не учитывая регистр)");
            else Console.WriteLine("Строки не равны");

            Console.ReadKey();
        }

        static void Task44()
        {
            Console.Clear();
            Console.WriteLine("Задание 44");
            int number;

            Console.Write($"Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Произошла ошибка! Введите корректное число!");
                Thread.Sleep(5000);
                Console.Clear();
                Console.Write($"Введите число: ");
            }

            Console.WriteLine($"Сумма чисел от нуля до {number}: {SumFromOneTo.Sum(number)}");

            Console.ReadKey();
        }

        static void Task45()
        {
            Console.Clear();
            Console.WriteLine("Задание 45");

            int[] array = new int[10];
            Random rnd = new Random();

            Console.WriteLine("\nНачальный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write($"{array[i]} ");
            }

            array = SortArray.Selection(array);
            Console.WriteLine("\nИтоговый массив, отсортированный убыванию с использованием алгоритма сортировки выбором:");
            foreach (int item in array) Console.Write($"{item} ");

            Console.ReadKey();
        }

        static void Task46()
        {
            Console.Clear();
            Console.WriteLine("Задание 46");
            Console.WriteLine("Калькулятор");
            int a, b;
            string operation = "";
            bool c = true;

            string mainText = (
                $"\nВыберите операцию:\n" +
                $" + сложение\n" +
                $" - вычитание\n" +
                $" * умножение\n" +
                $" / деление\n\n" +
                $"Выбор:"
                );

            Console.Write(mainText);
            while (c)
            {
                operation = Console.ReadLine();
                if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                {
                    c = false;
                }
                else
                {
                    Console.WriteLine("Произошла ошибка! Выберите корректную операцию!");
                    Thread.Sleep(5000);
                    Console.Clear();
                    Console.Write(mainText);
                }
            }

            Console.Write($"\nВведите первое число: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Произошла ошибка! Введите корректное число!");
                Thread.Sleep(5000);
                Console.Clear();
                Console.Write($"Введите первое число: ");
            }

            Console.Write($"\nВведите второе число: ");
            while (!int.TryParse(Console.ReadLine(), out b) || (operation == "/" && b == 0))
            {
                Console.WriteLine("Произошла ошибка! Введите корректное число!");
                Thread.Sleep(5000);
                Console.Clear();
                Console.Write($"Введите второе число: ");
            }


            // Console.WriteLine($"Результат: {SimpleСalculator.Сalculate(a, b, operation)}");

            float result = SimpleСalculator.Сalculate(a, b, operation);

            Console.WriteLine($"Результат: {result}");


            Console.ReadKey();

        }

        static void Task47()
        {
            Console.Clear();
            Console.WriteLine("Задание 47");
            int number;

            Console.Write($"Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Произошла ошибка! Введите корректное число!");
                Thread.Sleep(5000);
                Console.Clear();
                Console.Write($"Введите число: ");
            }

            if (SimpleNumber.Check(number)) Console.WriteLine($"Введённое вами число {number} простое!");
            else Console.WriteLine($"Введённое вами число {number} сложное!");

            Console.ReadKey();
        }

        static void Task48()
        {
            Console.Clear();
            Console.WriteLine("Задание 48");

            int number;

            Console.Write($"Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Произошла ошибка! Введите корректное число!");
                Thread.Sleep(5000);
                Console.Clear();
                Console.Write($"Введите число: ");
            }

            // Так как эта задача практически идентична задаче 44, нет смысла писать новый метод, поэтому используем старый (функционал тот же)
            int result = SumFromOneTo.Sum(number);
            Console.WriteLine($"Сумма всех цифр числа {number}: {result}");

            Console.ReadKey();
        }

        static void Task49()
        {
            Console.Clear();
            Console.WriteLine("Задание 49");

            int[] array = new int[10];
            Random rnd = new Random();

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                Console.Write($"{array[i]} ");
            }

            int result = SearchDuplicates.Search(array);

            Console.WriteLine($"\nКоличество дубликтов в данном массиве: {result}");

            Console.ReadKey();
        }

        static void Task50()
        {
            Console.Clear();
            Console.WriteLine("Задание 50");

            int size;
            Console.Write("Введите размер массива: ");
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Произошла ошибка! Введите корректное число!");
                Thread.Sleep(5000);
                Console.Clear();
                Console.Write("Введите размер массива: ");
            }


            int[] array = new int[size];
            array = GenerateArray.Generate(size);

            Console.WriteLine("Итоговый массив:");
            foreach (int item in array) Console.Write($"{item} ");

            Console.ReadKey();
        }

        static void Task51()
        {
            Console.Clear();
            Console.WriteLine("Задание 51");

            int temperature = 0;
            Console.Write($"Введите температуру по Цельсию: ");
            while (!int.TryParse(Console.ReadLine(), out temperature))
            {
                Console.WriteLine("Произошла ошибка! Введите корректное число!");
                Thread.Sleep(5000);
                Console.Clear();
                Console.Write($"Введите температуру по цельсию: ");
            }

            int result = TemperatureConverter.Convert(temperature);
            Console.WriteLine($"Температура {temperature}°C = {result}°F");

            Console.ReadKey();
        }

        static void Task52()
        {
            Console.Clear();
            Console.WriteLine("Задание 52");

            Console.Write("Введите строку: ");
            string line = Console.ReadLine();

            if (Palindrome.Check(line)) Console.WriteLine("Данная строка является палиндромом.");
            else Console.WriteLine("Данная строка не является палиндромом.");

            Console.ReadKey();
        }

        static void Task53()
        {
            Console.Clear();
            Console.WriteLine("Задание 53");

            Console.Write("Введите строку: ");
            string line = Console.ReadLine();

            (int, int) result = CountingVowelsConsonants.Counting(line);

            Console.WriteLine($"Данная строка содержит {result.Item1} гласных и {result.Item2} согласных.");

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание (39-53): ");
                switch (Console.ReadLine())
                {
                    case "39":
                        Task39();
                        break;

                    case "40":
                        Task40();
                        break;

                    case "41":
                        Task41();
                        break;

                    case "42":
                        Task42();
                        break;

                    case "43":
                        Task43();
                        break;

                    case "44":
                        Task44();
                        break;

                    case "45":
                        Task45();
                        break;

                    case "46":
                        Task46();
                        break;

                    case "47":
                        Task47();
                        break;

                    case "48":
                        Task48();
                        break;

                    case "49":
                        Task49();
                        break;

                    case "50":
                        Task50();
                        break;

                    case "51":
                        Task51();
                        break;

                    case "52":
                        Task52();
                        break;

                    case "53":
                        Task53();
                        break;

                    default:
                        Console.WriteLine("Произошла ошибкая! Сделайте корректный выбор:");
                        break;
                }
            }
        }
    }
}
