using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    class Tour
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            var matrix = GetMatrix(size);
            var distance = GetTourDistance(matrix);

            Console.WriteLine(distance);
        }

        static int GetTourDistance(int[,] matrix)
        {
            int[] path =
                Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int distance = 0;
            int currentCity = 0;
            foreach (int city in path)
            {
                distance += matrix[currentCity, city];
                currentCity = city;
            }
            return distance;
        }

        static int[,] GetMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow =
                    Console.ReadLine()
                        .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            return matrix;
        }
    }
}
