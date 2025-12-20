using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите факториал числа:");

            if (!long.TryParse(Console.ReadLine(), out long factorial))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число.");
                return;
            }

            if (factorial < 1)
            {
                Console.WriteLine("Факториал не может быть меньше 1.");
                return;
            }

            long currentNumber = factorial;
            int n = 1;

            while (currentNumber > 1)
            {
                n++;
                if (currentNumber % n == 0)
                {
                    currentNumber /= n;
                }
                else
                {
                    Console.WriteLine($"Число {factorial} не является факториалом.");
                    return;
                }
            }

            if (factorial == 1)
            {
                Console.WriteLine("Число 1 является факториалом 0! или 1!.");
            }
            else
            {
                Console.WriteLine($"Введенное число — это {n}!");
            }
        }
    }