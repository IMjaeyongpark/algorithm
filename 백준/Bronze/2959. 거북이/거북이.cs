using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int[] a = { int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]), int.Parse(s[3]) };
        for(int i = 0; i < 3; i++)
        {
            for(int j = i; j >= 0 && a[j] > a[j + 1]; j--)
            {
                int temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
            }
        }
        Console.WriteLine(a[0] * a[2]);
    }
}