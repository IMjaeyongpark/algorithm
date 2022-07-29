using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int[] price = new int[M];
        int pri = 0;
        int profit = 0;
        for(int i = 0; i < M; i++)
        {
            price[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(price);
        for(int j = 0; j < price.Length; j++)
        {
            int a = price[j] * M;
            if (a > profit && M <= N)
            {
                profit = a;
                pri = price[j];
            }
            M--;
        }
        Console.WriteLine(pri + " " + profit);
    }
}