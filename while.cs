using System;

public class WhileLoop
{
    public static void Main(string[] args)
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
        
        Console.ReadLine(); // Keeps the console window open until a key is pressed
    }
}
