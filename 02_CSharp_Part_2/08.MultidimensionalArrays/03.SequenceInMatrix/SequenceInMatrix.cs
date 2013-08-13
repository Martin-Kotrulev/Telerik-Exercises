using System;
/* 03.We are given a matrix of strings of size N x M.
 * Sequences in the matrix we define as sets of several
 * neighbor elements located on the same line, column or diagonal.
 * Write a program that finds the longest sequence 
 * of equal strings in the matrix. Example:
 * 
 * ha fifi ho hi                s  qq s
 * fo  ha  hi xx --> ha,ha,ha   pp pp s --> s,s,s
 * xxx ho  ha xx                pp qq s*/


class SequenceInMatrix
{
    static int maxSum = 0;
    static string maxValue;
    // Coordinates array for every direction
    static int[,] directions = { { 0, 1 }, { 1, 0 }, { 1, 1 }, { 1, -1 } };

    static void PrintMatrix(string[,] matrix)
    {
        int cellPadding = matrix[0, 0].Length;

        foreach (var cell in matrix)
        {
            // finding the size of the longest element and
            // assign it for a padding
            cellPadding = Math.Max(cellPadding, cell.Length);
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j].PadRight(cellPadding, ' ') + 
                    (j != matrix.GetLength(0) ? " " : "\n"));
            }
        }
    }

    static bool IsTraversable(string[,] matrix, int row, int col)
    {
        // Return true only if current coordinates are in
        // the boundaries of the matrix;
        return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
    }

    static void Check(string[,] matrix, bool[, ,] used, int row, int col)
    {
        // Checking all directions
        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
            // Skip if current direction is checked
            if (used[row, col, direction])
            {
                continue;
            }

            int currentSum = 0;
            int currentRow = row;
            int currentCol = col;

            // Building current sequence
            while (IsTraversable(matrix, currentRow, currentCol) && 
                matrix[row, col] == matrix[currentRow, currentCol])
            {
                currentSum++;
                used[currentRow, currentCol, direction] = true;
                currentRow += directions[direction, 0];
                currentCol += directions[direction, 1];
            }

            // Saving current best sequence
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxValue = matrix[row, col];
            }
        }
    }

    static void Main()
    {
        string[,] matrix = {{"ha", "fifi", "ho", "hi"},
                            {"fo", "ha", "hi", "xx"},
                            {"xxx", "ho", "ha", "xx"}};

        // three dimensional bool array for every direction to be checked
        bool[, ,] used = new bool[matrix.GetLength(0), matrix.GetLength(1), directions.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Check(matrix, used, i, j);
            }

        }
        PrintMatrix(matrix);
        Console.WriteLine(
            "Longest sequence is from element \"{0}\" and consist of {1} elements!" ,maxValue, maxSum);
    }
}

