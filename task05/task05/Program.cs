using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate(1, 2, 3) + Calculate(5, 3, 8) + Calculate(1, 5, 6);
            Console.WriteLine(Math.Round(x, 3));
        }

        static double Calculate(double a, double b, double c) =>
            Math.Sqrt((a + Math.Pow(Math.Tan(b),2)) / c);
        
    }
}
