using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число:");

            var n = int.Parse(Console.ReadLine());

            var hundreds = n / 100;
            var tenths = (n / 10) % 10;
            var units = n % 10;

            var result = tenths * 100 + hundreds * 10 + units;

            Console.WriteLine("Вот, каким было изначальное число: " + result);
        }
    }
}
