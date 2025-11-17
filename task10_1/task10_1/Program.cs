using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число больше нуля");

            int n;

            if(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода!");
                return;
            }

            if(n <= 0)
            {
                Console.WriteLine("Число должно быть больше нуля!");
                return;
            }

            double sum = 0;

            for (int a = 1; a <= n; a++)
                sum += Math.Sqrt(a);

            Console.WriteLine($"Сумма квадратных корней чисел от 1 до {n} равна {sum}");
        }
    }
}
