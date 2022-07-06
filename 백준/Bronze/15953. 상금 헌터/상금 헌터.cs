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
            int sum = 0;
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            if (a != 0)
            {
                if (a == 1) sum += 5000000;
                else if (a < 4) sum += 3000000;
                else if (a < 7) sum += 2000000;
                else if (a < 11) sum += 500000;
                else if (a < 16) sum += 300000;
                else if (a < 22) sum += 100000;
            }
            if (b != 0)
            {
                if (b == 1) sum += 5120000;
                else if (b < 4) sum += 2560000;
                else if (b < 8) sum += 1280000;
                else if (b < 16) sum += 640000;
                else if (b < 32) sum += 320000;
            }
            sb.Append(sum + "\n");
        }
        Console.Write(sb.ToString());
    }
}