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
            int m = int.Parse(Console.ReadLine());
            for(int j =0; j < m; j++)
            {
                sb.Append("=");
            }
            sb.Append("\n");
        }
        Console.WriteLine(sb);
    }
}