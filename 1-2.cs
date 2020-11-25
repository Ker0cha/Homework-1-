using System;
using System.Threading;
namespace Псевдокалькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите первое число");
            string first = Console.ReadLine();
            if (int.TryParse(first, out int num1) == false)
            {
                Console.WriteLine($"Неверный тип данных");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            Console.WriteLine($"Введите второе число");
            string second = Console.ReadLine();
            if (int.TryParse(second, out int num2) == false)
            {
                Console.WriteLine($"Неверный тип данных");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
                if (num2 == 0)
                { Console.WriteLine($"ERROR ERROR ERROR"); }
                else
                {
                    float c = (float)((double)num1 / num2);
                    Console.WriteLine(c);
                    Console.ReadKey();
            }
            }
        }
    }

