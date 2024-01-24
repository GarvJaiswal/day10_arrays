using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min=int.MaxValue;
            int[] arr = { 1, 2, 3, 4, 5, 6, 100, 200, -99, 990 };
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)   
                    min = arr[i];
            }
            Console.WriteLine("Max is " + max);
            Console.WriteLine("Min is " + min);
            Console.ReadLine();
        }
    }
}
