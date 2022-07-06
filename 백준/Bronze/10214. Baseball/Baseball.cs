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
            string W = "Yonsei";
            int Y = 0;
            int K = 0;
            for(int j=0; j < 9; j++)
            {
                string[] s = Console.ReadLine().Split();
                Y += int.Parse(s[0]);
                K += int.Parse(s[1]);
            }
            if (Y < K) W = "Korea";
            else if (Y == K) W = "Draw";
            sb.Append(W + "\n");
        }
        Console.WriteLine(sb);
    }
}