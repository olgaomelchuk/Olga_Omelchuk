using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите абсциссу точки");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ординату точки");
            var y = double.Parse(Console.ReadLine());

            if (IsInArea(x, y))
                Console.WriteLine("Точка лежит в указанной области");
            else
                Console.WriteLine("Точка не лежит  в указанной области");
        }

        static bool IsInArea(double x, double y) =>
            y >= -2 && (x <= -3 || x >= -1);
    }
}
