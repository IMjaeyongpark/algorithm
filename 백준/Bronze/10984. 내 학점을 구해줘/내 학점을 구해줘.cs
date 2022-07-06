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
            int count = 0;
            double score = 0.0;
            int M = int.Parse(Console.ReadLine());
            for(int j= 0; j < M; j++)
            {
                string[] s = Console.ReadLine().Split();
                count += int.Parse(s[0]);
                score += double.Parse(s[1])*double.Parse(s[0]);
            }
            score /= count;
            sb.Append(count + " " + $"{score:0.0}" + "\n");
        }
        Console.WriteLine(sb);
        
    }
}