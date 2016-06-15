using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixGenerator
{
    class MatrixGenerator
    {
        static void Main(string[] args)
        {
            string[] inputInformation = Console.ReadLine().Trim().Split().ToArray();
            char type = char.Parse(inputInformation[0]);

            int matrixRows = int.Parse(inputInformation[1]);
            int matrixCols = int.Parse(inputInformation[2]);

            int[,] matrix = new int[matrixRows, matrixCols];
            int value = 1;
            //int maxNumbersInMatrix = matrixRows * matrixCols;
            //int value = 1;

            if (type == 'A')
            {
                //first fill the matrix
                for (int cols = 0; cols < matrixCols; cols++)
                {
                    for (int rows = 0; rows < matrixRows; rows++, value++)
                    {
                        matrix[rows, cols] = value;
                    }
                }
            }
            else if (type == 'B')
            {
                for (int cols = 0; cols < matrixCols; cols++)
                {
                    if (cols % 2 == 0)
                    {
                        for (int rows = 0; rows < matrixRows; rows++, value++)
                        {
                            matrix[rows, cols] = value;
                        }
                    }
                    else
                    {
                        for (int rows = 0; rows < matrixRows; rows++, value++)
                        {
                            matrix[matrixRows - 1 - rows, cols] = value;
                        }
                    }                    
                }
            }
            else if (type == 'C')
            {

            }
            
            //write the matrix
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
