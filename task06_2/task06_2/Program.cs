using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано слово кинематограф");
            string input = "кинематограф";
            Console.WriteLine("Первое слово: " + firstConcat(input));
            Console.WriteLine("Второе слово: " + secondConcat(input));
        }

        static string firstConcat(string word)
        {
            string first = word.Substring(8);
            string second = word.Substring(7, 1);
            string third = word.Substring(4, 2);
            string forth = word.Substring(2, 1);

            var result = first + second + third + forth;
            return (result);
        }

        static string secondConcat(string word)
        {
            //string first = new string((word.Substring(3, 2)).Reverse().ToArray());
            string first = word.Substring(4, 1);
            string second = word.Substring(3, 1);
            string third = word.Substring(6, 1);
            string forth = word.Substring(9, 1);
            string fifth = word.Substring(7, 1);

            var result = first + second + third + forth + fifth;
            //var result = first + third + forth + fifth;
            return (result);
        }
    }
}
