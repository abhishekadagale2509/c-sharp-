using System;

public class DataType
{
    public static void Main(string[] args)
    {
        char c = 'a';
        int a = 34;
        double d = 34.4;
        float f = 34.4F;
        string s = "this is a string";
        int x=(int)3.5;
        Console.WriteLine("a val is " + a);
        Console.WriteLine("d val is " + d);
        Console.WriteLine("f val is " + f);
        Console.WriteLine("char is " + c);
        Console.WriteLine("string val is " + s);
        Console.WriteLine("typeCast is "+x);
    }
}
