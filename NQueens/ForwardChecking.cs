using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueens
{
    public class ForwardChecking 
    {
        public int BoardSize { get; set; }
        

        public string Solutions { get; set; }

        public int[] PlacedQueens { get; set; }
        

        public int[][] Table { get; set; }

        public ForwardChecking(int boardSize)
        {
            BoardSize = boardSize;
            PlacedQueens = new int[boardSize];
            Table = new int[boardSize][];

            for (int i = 0; i < boardSize; ++i)
            {
                Table[i] = new int[boardSize];
            }
        }


        public void solveNQueens()
        {
            Solutions = "";
            solveNQueenForwardCheckingArray(0);
        }

        public bool solveNQueenForwardCheckingArray(int col)
        {
            if (col == BoardSize)
            {
                foreach (var queen in PlacedQueens)
                {
                    Solutions += $"{queen},";
                }

                Solutions += "-";

                return true;
            }

            for (int i = 0; i < BoardSize; ++i)
            {
                if (Table[i][col] == 0)
                {
                    PlacedQueens[col] = i;
                    addInPlaces(i, col);
                    if (isSolutionPossible(col))
                    {
                        solveNQueenForwardCheckingArray(col + 1);
                    }
                    removeInPlaces(i, col);
                }
            }

            return false;
        }

        public void addInPlaces(int lastInsertedRow, int lastInsertedColumn)
        {
            recalculateFields(1, lastInsertedRow, lastInsertedColumn);
        }

        public void removeInPlaces(int lastInsertedRow, int lastInsertedColumn)
        {
            recalculateFields(-1, lastInsertedRow, lastInsertedColumn);
        }

        public void recalculateFields(int valueModifier, int lastInsertedRow, int lastInsertedColumn)
        {
            for (int j = 1; j < BoardSize - lastInsertedColumn; ++j)
            {
                Table[lastInsertedRow][lastInsertedColumn + j] += valueModifier;

                if (lastInsertedRow + j < BoardSize)
                {
                    Table[lastInsertedRow + j][lastInsertedColumn + j] += valueModifier;
                }
                if (lastInsertedRow - j >= 0)
                {
                    Table[lastInsertedRow - j][lastInsertedColumn + j] += valueModifier;
                }
            }
        }

        private bool isSolutionPossible(int lastInsertedColumn)
        {
            for (int i = lastInsertedColumn + 1; i < BoardSize; i++)
            {
                bool isAbleToPlaceInCurrentColumn = false;

                for (int row = 0; row < BoardSize && !isAbleToPlaceInCurrentColumn; row++)
                {
                    if (Table[row][i] == 0)
                    {
                        isAbleToPlaceInCurrentColumn = true;
                    }
                }

                if (!isAbleToPlaceInCurrentColumn) return false;
            }
            return true;
        }
    }
}
