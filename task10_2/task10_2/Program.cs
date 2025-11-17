using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число k - количество студентов в каждой из двух академических групп:");

            int k;

            if (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Ошибка ввода!");
                return;
            }

            if (k <= 0)
            {
                Console.WriteLine("Такого количества студентов в группе быть не может!");
                return;
            }

            Console.WriteLine("Введите возраст каждого студента 1-й группы:");

            double sum_first = 0;
            double medium_age;

            for (int a = 1; a <= k; a++)
            {
                double x;

                if (!double.TryParse(Console.ReadLine(), out x) || x <= 0)
                {
                    Console.WriteLine("Некорректный возраст!");
                    return;
                }

                sum_first += x;
            }

            medium_age = sum_first / k;
            Console.WriteLine($"Средний возраст студентов 1-й группы равен {medium_age}");

            Console.WriteLine("Введите возраст каждого студента 2-й группы:");

            double sum_second = 0;

            for (int a = 1; a <= k; a++)
            {
                double x;

                if (!double.TryParse(Console.ReadLine(), out x) || x <= 0)
                {
                    Console.WriteLine("Некорректный возраст!");
                    return;
                }

                sum_second += x;
            }

            medium_age = sum_second / k;
            Console.WriteLine($"Средний возраст студентов 2-й группы равен {medium_age}");
        }
    }
}
