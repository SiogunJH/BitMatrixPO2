using System;

public static class Program
{
    public static void Main()
    {
        // Equals dla parametru `null`
        BitMatrix m1 = new BitMatrix(1, 1);
        Console.WriteLine(m1.Equals(null));
    }
}
