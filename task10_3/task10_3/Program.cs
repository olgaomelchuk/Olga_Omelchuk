using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n - количество целых чисел:");

            int n;

            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода!");
                return;
            }

            if (n <= 0)
            {
                Console.WriteLine("Количество не может быть отрицательным или равняться нулю!");
                return;
            }

            Console.WriteLine("Введите целые числа:");

            int kMax;

            if (!int.TryParse(Console.ReadLine(), out kMax))
            {
                Console.WriteLine("Введите целое число!");
                return;
            }

            for (int a = 2; a <= n; a++)
            {
                int number;

                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Ошибка ввода!");
                    return;
                }

                if (number > kMax)
                    kMax = number;
            }

            Console.WriteLine($"Наибольшее число: {kMax}");
        }
    }
}
