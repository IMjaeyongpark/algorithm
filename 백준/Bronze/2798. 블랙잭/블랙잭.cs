using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        string[] s1 = Console.ReadLine().Split();
        int min = int.MinValue;

        for(int i = 0; i < N-2; i++)
        {
            int cur=0;
            for(int j = i+1; j < N - 1; j++)
            {
                for(int k = j+1; k < N; k++)
                {
                    cur = int.Parse(s1[i]) + int.Parse(s1[j]) + int.Parse(s1[k]);
                    if (min < cur && cur <= M) min = cur;
                }
            }
        }
        Console.WriteLine(min);
    }
}