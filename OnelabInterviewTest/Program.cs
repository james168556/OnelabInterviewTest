using System;
using System.Collections.Generic;

namespace OnelabInterviewTest
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int tableSize = 8;
            var QueensList = Queens.GetQueensList(tableSize);

            PrintQueensList(tableSize, QueensList);

            Console.WriteLine("Total Count = " + QueensList.Count);
            Console.Read();
        }

        private static void PrintQueensList(int tableSize, List<List<Queen>> QueensList)
        {
            foreach (var queens in QueensList)
            {
                foreach (var queen in queens)
                {
                    PrintQueen(tableSize, queen);
                }
                Console.WriteLine();
            }
        }

        private static void PrintQueen(int tableSize, Queen queen)
        {
            var result = new string[tableSize];

            for (int column = 1; column <= tableSize; column++)
            {
                if (column == queen.Column)
                {
                    result[column - 1] = "Q";
                }
                else
                {
                    result[column - 1] = ".";
                }
            }

            Console.WriteLine(string.Join(string.Empty, result));
        }
    }
}
