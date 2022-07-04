using System;

class Program
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            sum += int.Parse(s[0]) * int.Parse(s[1]);

        }
        if (sum == M) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}