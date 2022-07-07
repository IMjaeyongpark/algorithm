using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        char[,] c = new char[N, N];
        for(int i = 0; i < N; i++)
        {
            char[] s = Console.ReadLine().ToCharArray();
            for (int j = 0; j < N; j++) c[i, j] = s[j];
        }
        int m = int.Parse(Console.ReadLine());

        if(m == 1)
        {
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    sb.Append(c[i, j]);
                }
                sb.Append("\n");
            }
        }
        else if (m == 2)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = N - 1; j >= 0; j--)
                {
                    sb.Append(c[i, j]);
                }
                sb.Append("\n");
            }
        }
        else if (m == 3)
        {
            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = 0; j < N; j++)
                {
                    sb.Append(c[i, j]);
                }
                sb.Append("\n");
            }
        }
        Console.WriteLine(sb.ToString());
    }
}