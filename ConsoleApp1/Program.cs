using System;

namespace PyramidPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pyramid Pattern\n\n");

            int row = 5;
            int j, k;

            for (int i = 0; i <= row; i++)
            {

                for(j = 1; j <= row -  i; j++)
                    Console.Write(" ");

                for (k = 1; k <= 2 * i - 1 ; k++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}