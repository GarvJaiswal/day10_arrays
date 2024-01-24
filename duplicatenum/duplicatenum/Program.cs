using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicatenum
{
    internal class Program
    {
        public void countDup(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        count++;
                    else continue;
                }
                Console.WriteLine($"Number {nums[i]} exists {count} times");
            }
        }
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter the size of array");
            //nt n=Convert.ToInt32(Console.ReadLine());
            int[] arr = {1, 1, 3, 4,4,5,6,6};
           
            Program obj = new Program();
            obj.countDup(arr);
            Console.ReadLine();

        }
    }
}
