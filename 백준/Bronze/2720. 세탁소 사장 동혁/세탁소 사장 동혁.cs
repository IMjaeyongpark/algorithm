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
            decimal M = int.Parse(Console.ReadLine());
            M /= 100.0m;
            int a = (int)(M / 0.25m);
            M -= (decimal)a * 0.25m;
            int b = (int)(M / 0.10m);
            M -= (decimal)b * 0.10m;
            int c = (int)(M / 0.05m);
            M -= (decimal)c * 0.05m;
            M /= 0.01m;
            sb.Append(a + " " + b + " " + c + " " + M + "\n");
        }
        Console.WriteLine(sb);
    }
}