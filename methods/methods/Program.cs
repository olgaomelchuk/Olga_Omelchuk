using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = InputInteger("Введите 1-ю координату");
            var y = InputInteger("Введите 2-ю координату");

            Console.WriteLine("Точка (" + x + ", " + y + ")");
        }

        static int InputInteger(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
