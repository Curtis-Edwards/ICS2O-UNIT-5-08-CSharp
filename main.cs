using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int integer1;
        int integer2;
        var answer = 0;
        var remainder = 0;

        Console.WriteLine("Please enter 2 integers to be divided");
        Console.WriteLine("");

        Console.Write("integer 1: ");
        integer1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("integer 2: ");
        integer2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        var currentanswer = integer1;

        while (currentanswer > 0)
        {
            currentanswer = currentanswer - integer2;
            if (currentanswer >= 0)
            {
                answer++;
            }
        }
        while (currentanswer < 0)
        {
            currentanswer++;
            remainder++;
        }

        Console.WriteLine(" The answer is: " + answer + " The remainder is: " + remainder);

        Console.WriteLine("\nDone.");
    }
}