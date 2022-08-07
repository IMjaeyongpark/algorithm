using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        char[] S = Console.ReadLine().ToCharArray();
        int count = 0;
        for (int i = 0; i <= M - (2 * N + 1); i++)
        {
            if (S[i] == 'I')
            {
                int a = i;
                int cnt = 0;
                for (i = ++i; i < M; i++)
                {
                    if ((i - a) % 2 == 1 && S[i] == 'O') ;
                    else if ((i - a) % 2 == 0 && S[i] == 'I')
                    {
                        cnt++;
                        if (cnt >= N)
                        {
                            count++;
                        }
                    }
                    else break;
                }
                i--;
            }
        }
        Console.WriteLine(count);
    }
}