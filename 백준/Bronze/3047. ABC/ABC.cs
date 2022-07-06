using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int[] a = { int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]) };
        char[] c = Console.ReadLine().ToCharArray();
        int temp = 0;
        if (a[1] > a[2])
        {
            temp = a[1];
            a[1] = a[2];
            a[2] = temp;
        }
        if (a[0] > a[1])
        {
            temp = a[0];
            a[0] = a[1];
            a[1] = temp;
        }
        if (a[1] > a[2])
        {
            temp = a[1];
            a[1] = a[2];
            a[2] = temp;
        }
        Console.WriteLine(a[c[0] - 'A'] + " " + a[c[1] - 'A'] + " " + a[c[2] - 'A']);
    }
}