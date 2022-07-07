using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int[] a = { int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]) };
        for(int i = 0; i < 2; i++)
        {
            for (int j = i; j >= 0&& a[j] > a[j + 1]; j--)
            {
                int tmep = a[j];
                a[j] = a[j + 1];
                a[j + 1] = tmep;
            }
        }
        int d = 0;
        int b = a[1] - a[0];
        int c = a[2] - a[1];
        if (b == c) d = a[2] + b;
        else
        {
            if (b > c)
            {
                d = a[0] + c;
            }
            else d = a[1] + b;
        }
        Console.WriteLine(d);
    }
}