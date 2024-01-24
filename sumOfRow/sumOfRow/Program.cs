using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {{1,2,3},
             { 4,5,6},
             { 7,8,9 }
            };
            //int sum = 0;
            int rows=matrix.GetLength(0);
            int cols=matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum = sum + matrix[i, j];
                }
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
