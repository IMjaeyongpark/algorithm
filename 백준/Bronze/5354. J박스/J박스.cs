using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            int M = int.Parse(Console.ReadLine());
            for(int j = 0; j < M; j++)
            {
                if (j == 0 || j == M - 1)
                {
                    for(int k = 0; k < M; k++)
                    {
                        sb.Append("#");
                    }
                }
                else
                {
                    sb.Append("#");
                    for(int k = 0; k < M-2; k++)
                    {
                        sb.Append("J");
                    }
                    sb.Append("#");
                }
                sb.Append("\n");
            }
            sb.Append("\n");
        }
        Console.WriteLine(sb);
    }
}