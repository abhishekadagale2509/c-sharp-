using System;

public class ConditionalStat
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter age:");
        string ageStr = Console.ReadLine();  // Read input as a string
        int age = int.Parse(ageStr);         // Convert the input string to an integer

        if (age > 18)
        {
            Console.WriteLine("You are eligible.");
        }
        else
        {
            Console.WriteLine("You are not eligible.");
        }
    }
}
