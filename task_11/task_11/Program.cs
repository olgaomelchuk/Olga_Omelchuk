using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное значение первого члена геометрической прогрессии p:");

            var p = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите действительное значение знаменателя геометрической прогрессии q:");

            var q = double.Parse(Console.ReadLine());

            var n = 20;
            var numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = p * Math.Pow(q, i);
            }

            Console.WriteLine("Исходный массив:");
            PrintDoubleArray(numbers);

            DoubleArraySigns(numbers);

            Console.WriteLine("Массив после возведения каждого элемента в квадрат:");
            PrintDoubleArray(numbers);

            var geometricalAverage = GetGeometricallAverage(numbers);
            Console.WriteLine($"Среднее геометрическое элементов: {geometricalAverage:F6}\n");

            Console.WriteLine("Введите любое действительное число:");

            var k = double.Parse(Console.ReadLine());

            Console.WriteLine($"Массив после умножения каждого элемената на {k}:");
            PrintDoubleArray(MultiplicationByNumber(numbers, k));
        }

        static void PrintDoubleArray(double[] array)
        {
            foreach (var item in array)
                Console.Write($"{item}, ");

            Console.WriteLine("\b\b.\n");
        }

        static void DoubleArraySigns(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] *= array[i];
        }

        static double GetGeometricallAverage(double[] array)
        {
            if (array.Length == 0)
                return 0;

            double product = 1;

            foreach (var item in array)
                product *= item;

            return Math.Pow(product, 1.0 / array.Length);
        }

        static double[] MultiplicationByNumber(double[] array, double multiplier)
        {
            var result = new double[array.Length];

            for (int i = 0; i < result.Length; i++)
                result[i] = array[i] * multiplier;

            return result;
        }
    }
}
