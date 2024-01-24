using System;

class unique
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 3, 3, 2, 2, 1,1,2,3,9 };
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            int j;
            for (j = 0; j < i; j++)
                if (arr[i] == arr[j])
                    break;

            if (i == j)
                Console.Write(arr[i] + " ");
        }
        Console.ReadLine();
    }
}