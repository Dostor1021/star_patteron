using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the star pattern: ");
            int patternSize = Convert.ToInt32(Console.ReadLine());
            while (patternSize == 0)
            {
                Console.WriteLine("Please enter a valid positive integer.");
                Console.Write("Enter the size of the star pattern: ");
            }

            int j_size = 2 * patternSize - 1;
            int i_size = patternSize;

            for (int i = 0; i < i_size; i++)
            {
                for (int j = 0; j < j_size; j++)
                {
                    if (i >= 0 && i <= 5)
                    {
                        if (j >= i_size - i - 1 && j <= i_size + i - 1)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else if (i > 5 && i <= 10)
                    {
                        int n = i - 6;
                        if (j >= n && j <= j_size - n - 1)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else if (i == 11 && (j >= 4 && j <= 8 || j >= j_size - 1 - 8 && j <= j_size - 1 - 4))
                        Console.Write("*");
                    else if (i == 12 && (j >= 3 && j <= 6 || j >= j_size - 1 - 6 && j <= j_size - 1 - 3))
                        Console.Write("*");
                    else if (i == 13 && (j >= 2 && j <= 4 || j >= j_size - 1 - 4 && j <= j_size - 1 - 2))
                        Console.Write("*");
                    else if (i == 14 && (j >= 1 && j <= 2 || j >= j_size - 1 - 2 && j <= j_size - 1 - 1))
                        Console.Write("*");
                    else if (i == 15 && (j == 0 || j == j_size - 1))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
