using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        private static int[] NumbersToSort = { 343, 56, 8, 298, 10, 45, 3567, 87 };

        static void Main(string[] args)
        {
            try
            {
                int[] sortedNumbers = new int[NumbersToSort.Length];

                for (int i = 0; i < NumbersToSort.Length; i++)
                {
                    sortedNumbers[i] = NumbersToSort[i];
                }

                Console.WriteLine("--- BEFORE ---");

                for (int i = 0; i < sortedNumbers.Length; i++)
                {
                    Console.WriteLine(sortedNumbers[i]);
                }

                var newList = new List<int>();

                for (int i = 0; i < sortedNumbers.Length - 1; i++)
                {
                    if (NumbersToSort[i] > NumbersToSort[i + 1])
                    {
                        newList.Add(NumbersToSort[i]);
                    }
                    else
                    {
                        newList.Reverse();
                        newList.Add(NumbersToSort[i]);
                        newList.Reverse();
                    }
                }
                //for (int i = 0; i < 5; i++)
                //sortedNumbers = SortPass(sortedNumbers);

                sortedNumbers = newList.ToArray();

                Console.WriteLine("--- AFTER ---");
                for (int i = 0; i < sortedNumbers.Length; i++)
                {
                    Console.WriteLine(sortedNumbers[i]);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Exit();
        }

        private static int[] SortPass(int[] NumbersToSort)
        {
            for (int i = 0; i < NumbersToSort.Length - 1; i++)
            {
                if (NumbersToSort[i] > NumbersToSort[i + 1])
                {
                    int biggerNumber = NumbersToSort[i];
                    NumbersToSort[i] = NumbersToSort[i + 1];
                    NumbersToSort[i + 1] = biggerNumber;
                }
            }

            return NumbersToSort;
        }

        private static void Exit()
        {
            Console.WriteLine("Please press a key...");
            Console.ReadKey();
        }
    }
}
