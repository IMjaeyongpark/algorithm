using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        while (true)
        {
            string s = " is NOT a multiple of ";
            int a = int.Parse(Console.ReadLine());
            if (a == 0) break;
            if (a % N == 0)
            {
                s = s.Replace("NOT ", "");
            }
            sb.Append(a + s + N + ".\n");
        }
        Console.WriteLine(sb.ToString());
    }
}