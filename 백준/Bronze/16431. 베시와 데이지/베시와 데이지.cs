using System;

class Program
{
    static void Main()
    {
        string w = "tie";
        int[,] a = new int[3, 2];
        for(int i = 0; i < 3; i++)
        {
            string[] s = Console.ReadLine().Split();
            a[i, 0] = int.Parse(s[0]);
            a[i, 1] = int.Parse(s[1]);
        }
        int b = 0;
        int d = 0;
        int[] j = { a[2, 0], a[2, 1] };
        for (int i = 0; i < 2; i++)
        {
            int c = a[1, i] - j[i];
            if (c < 0) c *= -1;
            d += c;
        }
        a[0, 0] -= j[0];
        if (a[0, 0] < 0) a[0, 0] *= -1;
        a[0, 1] -= j[1];
        if (a[0, 1] < 0) a[0, 1] *= -1;
        b = a[0, 0] >= a[0, 1] ? a[0, 0] : a[0, 1];
        if (b < d) w = "bessie";
        else if (b > d) w = "daisy";
        Console.WriteLine(w);
    }
}