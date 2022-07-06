using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string ch = "neither";
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            if (a == 0 && b == 0) break;
            if (b % a == 0) ch = "factor";
            else if (a % b == 0) ch = "multiple";
            sb.Append(ch + "\n");
        }
        Console.Write(sb.ToString());
    }
}