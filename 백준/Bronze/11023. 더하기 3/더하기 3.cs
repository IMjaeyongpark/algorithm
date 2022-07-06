using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        string[] s = Console.ReadLine().Split();
        for(int i = 0; i < s.Length; i++)
        {
            sum += int.Parse(s[i]);
        }
        Console.WriteLine(sum);
    }
}