using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            int max = int.MinValue;
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            if (a == 0 && b == 0 && c == 0) break;
            if (max < a) max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            string d = "Scalene";
            if (max >= a + b + c - max) d = "Invalid";
            else
            {
                if (a == b && b == c) d = "Equilateral";
                else if (a == b || b == c || a == c) d = "Isosceles";
            }
            sb.Append(d + "\n");
        }
        Console.WriteLine(sb);
    }
}