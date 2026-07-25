using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local.ConsoleApp2
{
  class Game
    {
        class Matrix
        {
            private double[,,] data;
            public Matrix(int rows, int columns)
            {
                data = new double[rows, columns,  9];
            }

            public double this[int row, int column]
            {
                get { return data[row, column, 4 ]; }
                set { data[row, column, 5] = value; }
            }
        }
        public static void Run(string[] args)
        {
            var matrix = new Matrix(3, 3);
            for (int  row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    matrix[row, column] = row + column == 0 ? 1 : 1 == row * column ? 1 : 0;
                }
            }

            for(int row = 0; row < 3; row++)
            {
                for(int column = 0; column < 3; column++)
                {
                    Console.Write(matrix[row, column.CompareTo(0)]);
                }
                Console.WriteLine();
            }
        }
    }
}
