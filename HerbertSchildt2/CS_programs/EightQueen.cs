using System;

namespace EightQueen
{
    public enum SIZE
    {
        size = 8
    }
    public class EightQueen
    {
        public static int count = 0;
        public static bool isValidMove(int[,] boardArr, int row, int col)
        {
            for (int i = 0; i < SIZE.size.GetHashCode(); i++)
                if (boardArr[row, i] == 1)
                    return false;

            for (int i = 0; i < SIZE.size.GetHashCode(); i++)
                if (boardArr[i, col] == 1)
                    return false;
            int tempCol = col + 1, tempRow = row;

            for (int i = row + 1; i < SIZE.size.GetHashCode(); i++)
            {
                if (tempCol < SIZE.size.GetHashCode())
                {
                    if (boardArr[i, tempCol] == 1)
                        return false;
                    else
                        tempCol++;
                }
                else
                    break;
            }
            tempCol = col - 1;
            for (int i = row - 1; i >= 0; i--)
            {
                if (tempCol >= 0)
                {
                    if (boardArr[i, tempCol] == 1)
                        return false;
                    else
                        tempCol--;
                }
                else
                    break;
            }
            tempCol = col - 1;
            for (int i = row + 1; i < SIZE.size.GetHashCode(); i++)
            {
                if (tempCol >= 0)
                {
                    if (boardArr[i, tempCol] == 1)
                        return false;
                    else
                        tempCol--;
                }
                else
                    break;
            }
            tempCol = col + 1;
            for (int i = row - 1; i >= 0; i--)
            {
                if (tempCol < SIZE.size.GetHashCode())
                {
                    if (boardArr[i, tempCol] == 1)
                        return false;
                    else
                        tempCol++;
                }
                else
                    break;
            }

            return true;
        }

        public static void ShouldPrintBoard(int[,] boardArr)
        {
            int count = 0;
            for (int i = 0; i < SIZE.size.GetHashCode(); i++)
                for (int j = 0; j < SIZE.size.GetHashCode(); j++)
                    if (boardArr[i, j] == 1)
                        count++;
            if (count >= 8)
                PrintBoard(boardArr);
        }
        public static void PrintBoard(int[,] boardArray)
        {
            for (int i = 0; i < SIZE.size.GetHashCode(); i++)
            {
                for (int j = 0; j < SIZE.size.GetHashCode(); j++)
                    Console.Write("{0} ", boardArray[i, j]);
                Console.WriteLine();
            }
            count++;
            Console.WriteLine();
            //Console.ReadKey();
        }
        public static void PermuteBoard(int[,] boardArr, int row, int col)
        {
            for (int i = row; i < SIZE.size.GetHashCode(); i++)
            {
                for (int j = 0; j < SIZE.size.GetHashCode(); j++)
                {
                    if (isValidMove(boardArr, i, j))
                    {
                        boardArr[i, j] = 1;
                        ShouldPrintBoard(boardArr);
                        PermuteBoard(boardArr, i + 1, j + 1);
                        boardArr[i, j] = 0;
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            int[,] boardArr =new int[SIZE.size.GetHashCode(), SIZE.size.GetHashCode()];
            for (int i = 0; i < SIZE.size.GetHashCode(); i++)
                for (int j = 0; j < SIZE.size.GetHashCode(); j++)
                    boardArr[i, j] = 0;
            PermuteBoard(boardArr, 0, 0);

            Console.WriteLine("Total Solutions {0}", count);
            Console.ReadKey();
        }
    }
}