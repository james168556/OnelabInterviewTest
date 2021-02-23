using System;
using System.Collections.Generic;

namespace OnelabInterviewTest
{
    public class Queens
    {
        public static List<List<Queen>> GetQueensList(int n)
        {
            return PlaceQueens(n, n);
        }

        private static List<List<Queen>> PlaceQueens(int n, int row)
        {
            var queenList = new List<List<Queen>>();

            if (row == 0)
            {
                queenList.Add(new List<Queen>());
            }
            else
            {
                foreach (var queens in PlaceQueens(n, row - 1))
                {
                    for (int column = 1; column <= n; column++)
                    {
                        var queen = new Queen(row, column);
                        if (CanAddQueen(queen, queens))
                        {
                            var qs = new List<Queen>();
                            qs.AddRange(queens);
                            qs.Add(queen);
                            queenList.Add(qs);
                        }
                    }
                }
            }

            return queenList;
        }

        private static bool CanAddQueen(Queen queen, List<Queen> queens)
        {
            foreach (var q in queens)
            {
                if (IsSafe(queen, q))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsSafe(Queen q1, Queen q2)
        {
            if (q1.Row == q2.Row ||
                q1.Column == q2.Column ||
                Math.Abs(q1.Row - q2.Row) == Math.Abs(q1.Column - q2.Column))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

