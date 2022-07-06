using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        for (int j = 0; j < N; j++)
        {
            int sum = 0;
            int min = int.MaxValue;
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < 7; i++)
            {
                int a = int.Parse(s[i]);
                if (a % 2 == 0)
                {
                    sum += a;
                    if (min > a) min = a;
                }
            }
            sb.Append(sum + " " + min + "\n");
        }
        Console.WriteLine(sb.ToString());
    }
}