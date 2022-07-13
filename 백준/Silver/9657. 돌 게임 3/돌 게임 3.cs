using System;

class Program
{
    static void Main()
    {
        int[] dp = new int[1001];
        dp[2] = 1;
        int N = int.Parse(Console.ReadLine());
        for(int i = 6; i <= N; i++)
        {
            dp[i] = 1;
            if (dp[i - 1] == 1) dp[i] = 0;
            if (dp[i - 3] == 1) dp[i] = 0;
            if (dp[i - 4] == 1) dp[i] = 0;

        }
        string s = "SK";
        if (dp[N] == 1) s = "CY";
        Console.WriteLine(s);
    }
}