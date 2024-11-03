using System;

public class WhileLoop
{
    public static void Main(string[] args)
    {
        int i = 0;
        
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 5);
        
        Console.ReadLine(); // Keeps the console window open until a key is pressed
    }
}
