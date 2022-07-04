using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int[] a = new int[5];
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            a[i] = int.Parse(s[i]);
            sum += (a[i] * a[i]);
        }
        Console.WriteLine(sum%10);

    }
}