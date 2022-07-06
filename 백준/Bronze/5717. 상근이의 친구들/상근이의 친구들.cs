using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string[] s = Console.ReadLine().Split();
            if (int.Parse(s[0]) == 0 && int.Parse(s[1]) == 0) break;
            sb.Append(int.Parse(s[0])+ int.Parse(s[1])+"\n");
        }
        Console.WriteLine(sb);
    }
}