using System;

class Program
{
    static void Main()
    {
        int[] a = new int[2];
        for(int i = 0; i < a.Length; i++)
        {
            string[] s = Console.ReadLine().Split();
            for(int j = 0; j < s.Length; j++)
            {
                a[i] += int.Parse(s[j]);
            }

        }
        int b = a[0] >= a[1] ? a[0] : a[1];
        Console.WriteLine(b);
    }
}