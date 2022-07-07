using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N =int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            double a = double.Parse(Console.ReadLine());
            a = a * 80.0 / 100.0;
            sb.Append($"${a:0.00}" + "\n");
        }
        Console.WriteLine(sb.ToString());
    }
}