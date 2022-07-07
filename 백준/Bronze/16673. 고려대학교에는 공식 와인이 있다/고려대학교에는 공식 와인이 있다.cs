using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int C = int.Parse(s[0]);
        int K = int.Parse(s[1]);
        int P = int.Parse(s[2]);
        int count = 0;
        for(int i = 1; i <= C; i++)
        {
            count += K * i + P * i * i;
        }
        Console.WriteLine(count);
        
    }
}