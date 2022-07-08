using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int sum = 0;
        for(int i = 0; i < s.Length; i++)
        {
            sum += 5 * int.Parse(s[i]);
        }
        Console.WriteLine(sum);
    }
}