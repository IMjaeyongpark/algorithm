using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int i = 1;
        while (true)
        {
            string c = "even ";
            int N = int.Parse(Console.ReadLine());
            if (N == 0) break;
            N *= 3;
            int a = N % 2;
            N = (N + a) / 2;
            N *= 3;
            N /= 9;
            
            if (a == 1) c = "odd ";
            sb.Append(i++ +". "+ c + N + "\n");
        }
        Console.WriteLine(sb);
    }
}