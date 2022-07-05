using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int K = int.Parse(s[2]);

        for(int i = 0; i < K; i++)
        {
            if (N / 2 >= M)
            {
                N--;
            }
            else if(N / 2 < M)
            {
                M--;
            }
        }
        int a = N / 2 <= M ? N / 2 : M;
        Console.WriteLine(a);
    }
}