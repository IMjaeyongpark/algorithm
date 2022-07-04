using System;

class Program
{
    static void Main()
    {
        int[] h = { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
        int[] d = { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };

        int min = int.MaxValue;
        int sum = 0;

        for(int i=0; i<h.Length; i++)
        {
            if (min > h[i])min = h[i];
        }
        sum += min;
        min = int.MaxValue;
        for(int i=0; i<d.Length; i++)
        {
            if (min > d[i]) min = d[i];
        }
        sum += min;
        Console.WriteLine(sum - 50);
    }
}