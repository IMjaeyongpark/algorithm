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
            for(int j = 0; j < N-i; j++)
            {
                sb.Append(" ");
            }
            for(int j = 0; j < i; j++)
            {
                sb.Append("* ");
            }
            sb.Append("\n");
        }
        Console.WriteLine(sb.ToString());
    }
}