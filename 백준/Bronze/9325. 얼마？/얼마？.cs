using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int P = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            for (var j = 0; j < M; j++)
            {
                string[] s = Console.ReadLine().Split();
                if (int.Parse(s[0]) == 0) break;
                P += int.Parse(s[0]) * int.Parse(s[1]);
            }
            sb.Append(P + "\n");
        }
        Console.WriteLine(sb);
    }
}