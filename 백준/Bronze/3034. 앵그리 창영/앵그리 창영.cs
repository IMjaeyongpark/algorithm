using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int W = int.Parse(s[1]);
        int H = int.Parse(s[2]);
        int a = W * W + H * H;
        for(int i = 0; i < N; i++)
        {
            int b = int.Parse(Console.ReadLine());
            if (b * b <= a) sb.Append("DA\n");
            else sb.Append("NE\n");
        }
        Console.WriteLine(sb);
    }
}