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
            int sum = 0;
            int M = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            for(int j = 0; j < M; j++)
            {
                sum += int.Parse(s[j]);
            }
            sb.Append(sum + "\n");
        }
        Console.WriteLine(sb.ToString());
    }
}