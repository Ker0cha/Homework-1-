using System;

namespace Квадратные_уравнения
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введиите коэффициент A ");
                string a = Console.ReadLine();
            if (int.TryParse(a, out int A) == false)
            {
                Console.Write($"Неверный тип данных");
                Console.ReadKey();
                Environment.Exit(0);
            }
           
            Console.WriteLine($"Введиите коэффициент B ");
                
            string b = Console.ReadLine();
            if (int.TryParse(b, out int B) == false)
            {
                Console.Write($"Неверный тип данных");
                Console.ReadKey();
                Environment.Exit(0);
            }
           
            Console.WriteLine($"Введиите свободный член C ");
               
            string c = Console.ReadLine();
            if (int.TryParse(c, out int C ) == false)
            {
                Console.Write($"Неверный тип данных");
                Console.ReadKey();
                Environment.Exit(0);
            }
             
            float D = B * B - 4 * A * C;
            if( D < 0)
            {
                Console.WriteLine($"Действительных корней не существует");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (D == 0)
            {
                Console.WriteLine($"Существует только один корень");
                double x = (-B) / (2 * A);
                Console.WriteLine($"x = {x}");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (A == 0)
            {
                float x = -C / B;
                Console.WriteLine($"x = {x}");
                Console.ReadKey();
                Environment.Exit(0);

            }
            double x1 = (-B + Math.Sqrt(D)) / ( 2 * A );
            double x2 = (-B - Math.Sqrt(D)) / ( 2 * A );
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
    }
}
