using System;

class Program
{
    static void Main()
    {

        string[] s = Console.ReadLine().Split();
        int[] a = new int[3];
        for(int i = 0; i < s.Length; i++)
        {
            a[i] = int.Parse(s[i]);
        }

        int m = a[0] * a[1] - a[2];
        if (m < 0) m = 0;
        Console.WriteLine(m);
    }
}