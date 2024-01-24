using System;
class HelloWorld
{
    static void Main()
    {
        for (int i = 8; i >=1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                    Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
