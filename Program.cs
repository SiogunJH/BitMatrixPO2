using System;

public static class Program
{
    public static void Main()
    {

        // Parse, string pusty
        try
        {
            Console.WriteLine(BitMatrix.Parse(string.Empty));
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Pass");
            return;
        }
        Console.WriteLine("Fail");
    }
}
