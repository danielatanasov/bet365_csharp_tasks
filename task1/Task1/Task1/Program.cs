using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the dimensions of the array:");
            string sSize = Console.ReadLine();
            int mxSize = 0;

            while (!int.TryParse(sSize, out mxSize))
            {
                Console.WriteLine("Please enter the dimension of the array:");
                sSize = Console.ReadLine();
            }


            int[][] matrix = new int[mxSize][];
            int i, j;
            int temp = 0;

            for (i = 0; i < mxSize; i++)
            {
                matrix[i] = new int[mxSize];
                for (j = 0; j < mxSize; j++)
                {
                    matrix[i][j] = temp;
                    temp++;

                }
            }

            for (int x = 0; x < mxSize; x++)
            {
                for (int y = 0; y < mxSize; y++)
                {
                    Console.Write("{0}{1}", matrix[x][y], y == (matrix[x].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Please enter the coordinates of the element you want to increment divided by space: ");

            string sCoords = null;
            int coordX, coordY;
            while (
               !string.IsNullOrEmpty(sCoords = Console.ReadLine()))
            {
                string[] coords = sCoords.Split(' ');
                int.TryParse(coords[0], out coordX);
                int.TryParse(coords[1], out coordY);

                int incrementElem = matrix[coordX][coordY];
                incrementElem++;
                Console.WriteLine("The value incremented element at index [{1}][{2}] is: {0}", incrementElem, coordX, coordY);
            }
        }
    }
}