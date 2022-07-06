using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        for(int i = 1; i <= N; i++)
        {
            if (i != N)
            {
                for(int j = 0; j < N-i; j++)sb.Append(" ");
                sb.Append("*");
                for (int j = 0; j < 2 * (i - 1) - 1; j++) sb.Append(" ");
                if (i != 1) sb.Append("*");
                sb.Append("\n");
            }
            else
            {
                for (int j = 0; j < 2 * N - 1; j++) sb.Append("*");
            }
        }
        Console.WriteLine(sb.ToString());
        
    }
}