using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueDigitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Трехзначные числа с разными цифрами в возрастающем порядке:");
            Console.WriteLine();

            for (int i = 100; i <= 999; i++)
            {
                int numb = i;

                int d3 = numb % 10;          // единицы
                int d2 = (numb / 10) % 10;   // десятки
                int d1 = numb / 100;         // сотни

                if (d1 != d2 && d1 != d3 && d2 != d3)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}