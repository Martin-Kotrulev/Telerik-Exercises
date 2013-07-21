using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 06. Write a class Matrix, 
 * to holds a matrix of integers. 
 * Overload the operators for adding, 
 * subtracting and multiplying of matrices, 
 * indexer for accessing the matrix content and ToString().*/


class Matrix
{
    public int Row, Col;
    private int[,] matrix;

    // Constructor
    public Matrix(int x, int y)
    {
        matrix = new int[x, y];
        Row = x;
        Col = y;
    }

    // Get; Set;
    public int this[int x, int y]
    {
        get { return matrix[x, y]; }
        set { matrix[x, y] = value; }
    }

    // Addition
    public static Matrix operator +(Matrix fMatrix, Matrix sMatrix)
    {
        Matrix resultMatrix = new Matrix(fMatrix.Row, sMatrix.Col);

        for (int i = 0; i < resultMatrix.Row; i++)
        {
            for (int j = 0; j < resultMatrix.Col; j++)
            {
                resultMatrix[i, j] = fMatrix[i, j] + sMatrix[i, j];
            }
        }
        return resultMatrix;
    }

    // Subtraction
    public static Matrix operator -(Matrix fMatrix, Matrix sMatrix)
    {
        Matrix resultMatrix = new Matrix(fMatrix.Row, sMatrix.Col);

        for (int i = 0; i < resultMatrix.Row; i++)
        {
            for (int j = 0; j < resultMatrix.Col; j++)
            {
                resultMatrix[i, j] = fMatrix[i, j] - sMatrix[i, j];
            }
        }
        return resultMatrix;
    }

    public static Matrix operator *(Matrix fMatrix, Matrix sMatrix)
    {
        Matrix resultMatrix = new Matrix(fMatrix.Row, sMatrix.Col);

        for (int i = 0; i < resultMatrix.Row; i++)
        {
            for (int j = 0; j < resultMatrix.Col; j++)
            {
                for (int k = 0; k < fMatrix.Col; k++)
                {
                    resultMatrix[i, j] += fMatrix[i, j] * sMatrix[i, j];
                }
            }
        }
        return resultMatrix;
    }

    //TODO: Print
    public override string ToString()
    {
        int max = this.matrix[0, 0];

        // creating padding
        foreach (var cell in this.matrix)
        {
            max = Math.Max(max, cell);
        }
        int cellPadding = Convert.ToString(max).Length;

        string s = String.Empty;

        for (int i = 0; i < this.Row; i++)
        {
            for (int j = 0; j < this.Col; j++)
            {
                s += (Convert.ToString(this.matrix[i, j]).PadRight(cellPadding, ' ') +
                    (j != this.Col - 1 ? " " : "\n"));
            }
        }
        return s;
    }
}

class Program
{
    static void Main()
    {
        Matrix m1 = new Matrix(3, 3);
        Matrix m2 = new Matrix(3, 3);
        int test = 2;

        for (int i = 0; i < m1.Row; i++)
        {
            for (int j = 0; j < m1.Col; j++)
            {
                m1[i, j] = test;
                m2[i, j] = test;
            }
        }
         

        Console.WriteLine("Matrix 1");
        Console.WriteLine(m1);

        Console.WriteLine("Matrix 2");
        Console.WriteLine(m2);

        Console.WriteLine("Matrix 1 + Matrix 2");
        Console.WriteLine(m1 + m2);

        Console.WriteLine("Matrix 1 - Matrix 2");
        Console.WriteLine(m1 - m2);

        Console.WriteLine("Matrix 1 * Matrix 2");
        Console.WriteLine(m1 * m2);
    }
}

