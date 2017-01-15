using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[,] matrix = new int[size[0], size[1]];
        for (int i = 0; i < size[0]; i++)
        {
            int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int j = 0; j < size[1]; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        int bestSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (bestSum < sum)
                {
                    bestSum = sum;
                }
            }
        }
        Console.WriteLine(bestSum);
    }
}
