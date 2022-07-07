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
            string[] s = Console.ReadLine().Split();
            double sum = double.Parse(s[0])* 350.34;
            sum += double.Parse(s[1]) * 230.90;
            sum += double.Parse(s[2]) * 190.55;
            sum += double.Parse(s[3]) * 125.30;
            sum += double.Parse(s[4]) * 180.90;
            sb.Append($"${sum:0.00}\n");
        }
        Console.WriteLine(sb);
    }
}