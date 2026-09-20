using System;
class Program
{
    static void InChuIVaU()
    {
        Console.WriteLine("In chu I va U:");

        // In chu I
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 0 || i == 4 || j == 2)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.Write("   ");

            // In chu U
            for (int j = 0; j < 5; j++)
            {
                if ((j == 0 && i < 4) ||
                    (j == 4 && i < 4) ||
                    (i == 4 && j > 0 && j < 4))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        InChuIVaU();
    }
}