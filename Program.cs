using System;

public static class Program
{
    public static void Main()
    {

        // indekser - indeksy poza zakresem
        int[] arr = new int[] { -1, 1, 3, 4 };
        foreach (var i in arr)
            foreach (var j in arr)
            {
                var m = new BitMatrix(3, 4);
                try
                {
                    m[i, j] = 1;
                    Console.WriteLine($"m[{i}, {j}] = {m[i, j]}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"m[{i}, {j}] = exception");
                }
            }
    }
}
