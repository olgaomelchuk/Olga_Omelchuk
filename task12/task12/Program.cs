using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;

            while (true)
            {
                Console.WriteLine("Введите через пробел два натуральных числа n и m от 5 до 20");
                Console.WriteLine("(Enter - отказ от ввода)");
                var input = Console.ReadLine();

                if (input == string.Empty)
                    return;

                var strings = input.Split();

                if (strings.Length == 2 && int.TryParse(strings[0], out m) && int.TryParse(strings[1], out n) &&
                    5 <= m && m <= 20 && 5 <= n && n <= 20)
                    break;
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                    continue;
                }
            }

            var matrix = new int[m, n]; //создаём двумерный массив m - число строк, n - число столбцов

            var rnd = new Random(); //генератор случайных чисел

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(0, 100);

            Console.WriteLine();
            PrintTable(matrix);

            Console.WriteLine();

            if (AreElementsInAscendingOrder(matrix, out int rowIndex, out int firstColIndex, out int secondColIndex))
            {
                Console.WriteLine($"Нарушение порядка возрастания: элемент [{rowIndex},{firstColIndex}] больше элемента [{rowIndex},{secondColIndex}] или равен ему.");
            }
            else
            {
                Console.WriteLine("Все строки массива упорядочены по возрастанию");
            }

            Console.WriteLine();

            var sums = GetSumOfOddElementsInColumns(matrix);

            Console.WriteLine("Суммы нечетных элементов по столбцам:");
            for (int j = 0; j < sums.Length; j++)
            {
                Console.WriteLine($"В столбце {j} сумма нечетных элементов = {sums[j]}");
            }
        }

        static void PrintTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    Console.Write($"{table[i, j],2} ");

                Console.WriteLine();
            }
        }

        static bool AreElementsInAscendingOrder(int[,] table, out int rowIndex, out int firstColIndex, out int secondColIndex)
        {
            rowIndex = firstColIndex = secondColIndex = -1;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1) - 1; j++)
                {
                    if (table[i, j] >= table[i, j + 1])
                    {
                        rowIndex = i;
                        firstColIndex = j;
                        secondColIndex = j + 1;
                        return true;
                    }
                }
            }

            return false;
        }

        static int[] GetSumOfOddElementsInColumns(int[,] table)
        {
            var result = new int[table.GetLength(1)];

            for (int j = 0; j < table.GetLength(1); j++)
            {
                int sum = 0;

                for (int i = 0; i < table.GetLength(0); i++)
                {
                    if (table[i, j] % 2 != 0)
                    {
                        sum += table[i, j];
                    }
                }

                result[j] = sum;
            }

            return result;
        }
    }
}
