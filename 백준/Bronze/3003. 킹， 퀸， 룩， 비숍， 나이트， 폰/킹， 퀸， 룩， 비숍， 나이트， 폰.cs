using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int[] a = { 1, 1, 2, 2, 2, 8 };
        for (int i = 0; i < s.Length; i++)
        {
            a[i] -= int.Parse(s[i]);
            Console.Write(a[i] + " ");
        }
        
    }
}