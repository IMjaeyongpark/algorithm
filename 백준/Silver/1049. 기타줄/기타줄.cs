using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int min6 = int.MaxValue;
        int min1 = int.MaxValue;
        int price = 0;
        for(int i = 0; i < M; i++)
        {
            string[] s1 = Console.ReadLine().Split();
            if (min6 > int.Parse(s1[0])) min6 = int.Parse(s1[0]);
            if (min1 > int.Parse(s1[1])) min1 = int.Parse(s1[1]);
        }
        if (min6 >= min1 * 6) price = min1 * N;
        else
        {
            price = min6 * (N / 6);
            N %= 6;
            if (N * min1 < min6) price += N * min1;
            else price += min6;
        }
        Console.WriteLine(price);
    }
}