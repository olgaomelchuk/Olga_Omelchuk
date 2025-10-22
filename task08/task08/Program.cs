using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число m");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число n");
            var n = int.Parse(Console.ReadLine());

            if (IfLogicalExpresionTrue(m, n))
                Console.WriteLine("И m, и n больше 10");
            else
                Console.WriteLine("Одно из введённых чисел меньше или равно 10");
        }

        static bool IfLogicalExpresionTrue(int m, int n) =>
            m > 10 && n > 10;
    }
}
