using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximumValueForAB = 450; //данное ограничение помогает оптимизировать код

            long minimumSumWithThreeRepresentations = long.MaxValue;

            int[] firstCubeNumbers = new int[3];
            int[] secondCubeNumbers = new int[3];

            for (int firstNumberA = 1; firstNumberA <= maximumValueForAB; firstNumberA++)
            {
                long cubeOfFirstNumberA =
                    (long)firstNumberA * firstNumberA * firstNumberA;

                for (int firstNumberB = firstNumberA; firstNumberB <= maximumValueForAB; firstNumberB++)
                {
                    long currentSumOfCubes =
                        cubeOfFirstNumberA +
                        (long)firstNumberB * firstNumberB * firstNumberB;

                    if (currentSumOfCubes >= minimumSumWithThreeRepresentations)
                    {
                        continue;
                    }

                    int numberOfRepresentations = 0;

                    for (int secondNumberA = 1;
                         secondNumberA <= maximumValueForAB;
                         secondNumberA++)
                    {
                        long cubeOfSecondNumberA =
                            (long)secondNumberA * secondNumberA * secondNumberA;

                        for (int secondNumberB = secondNumberA;
                             secondNumberB <= maximumValueForAB;
                             secondNumberB++)
                        {
                            if (cubeOfSecondNumberA +
                                (long)secondNumberB * secondNumberB * secondNumberB
                                == currentSumOfCubes)
                            {
                                if (numberOfRepresentations < 3)
                                {
                                    firstCubeNumbers[numberOfRepresentations] =
                                        secondNumberA;
                                    secondCubeNumbers[numberOfRepresentations] =
                                        secondNumberB;
                                }

                                numberOfRepresentations++;

                                if (numberOfRepresentations > 3)
                                {
                                    break;
                                }
                            }
                        }

                        if (numberOfRepresentations > 3)
                        {
                            break;
                        }
                    }

                    if (numberOfRepresentations == 3)
                    {
                        minimumSumWithThreeRepresentations =
                            currentSumOfCubes;
                    }
                }
            }

            Console.Write("T(3) = " + minimumSumWithThreeRepresentations + " = ");

            for (int index = 0; index < 3; index++)
            {
                Console.Write(firstCubeNumbers[index] + "^3 + " + secondCubeNumbers[index] + "^3");

                if (index < 2)
                {
                    Console.Write(" = ");
                }
            }

            Console.WriteLine();
        }
    }
}