using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace task10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");

            var n = int.Parse(Console.ReadLine());

            for (int digit = 0; digit <= 9; digit++)
            {
                int count = 0;
                int numb = n;

                while (numb > 0)
                {
                    if(numb % 10 == digit)
                    {
                        count++;
                    }
                    numb /= 10;
                }

                if (count > 1)
                {
                    Console.WriteLine("Все цифры в числе должны быть различны.");
                    return;
                }
            }

            int maxDigit = -1;
            int i = -1;
            int index = -1;

            var number = n;

            while (number > 0)
            {
                int digit = number % 10;
                i++;
                number /= 10;

                if (digit > maxDigit)
                {
                    maxDigit = digit;
                    index = i;
                }
            }

            Console.WriteLine($"В числе {n} порядковый номер наибольшей цифры, считая справа налево, начиная с 0, равен {index}.");
        }
    }
}
