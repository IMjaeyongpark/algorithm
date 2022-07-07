using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string[] s= Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            if (a == 0 && b == 0 && c == 0) break;
            if (b - a == c - b) sb.Append("AP " + (c + b - a) + "\n");
            else sb.Append("GP " + (c * b /a) + "\n");
        }
        Console.WriteLine(sb);
    }
}