using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();
        int count = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if (N%10 == int.Parse(s[i])) count++;
        }
        Console.WriteLine(count);
    }
}