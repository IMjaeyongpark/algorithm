using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int[] a = { int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]) };
        if (a[0] >= a[1] && a[0] >= a[2])
        {
            Console.WriteLine(a[1] >= a[2] ? a[1] : a[2]);
        }
        else
        {
            int b = a[1] <= a[2] ? a[1] : a[2];
            Console.WriteLine(a[0] >= b ? a[0] : b);
        }
    }
}