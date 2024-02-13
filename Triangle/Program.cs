using System;

class Program
{
    static void Main(string[] args)
    {
        // Printing left-side triangle with N = 5
        PrintTriangle(5, "left");
        
        // Printing right-side triangle with N = 5
        PrintTriangle(5, "right");
    }

    // Method to print a triangle based on the shape and the number of rows
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine("N: {0}, Shape: {1}", N, shape);

        if (shape == "left")
        {
            // Print left-side triangle
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        else if (shape == "right")
        {
            // Print right-side triangle
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N - i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid shape.");
        }
    }
}