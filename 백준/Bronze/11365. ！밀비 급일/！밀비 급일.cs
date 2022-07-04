using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string s =Console.ReadLine();
            if (s == "END") break;
            char[] c = s.ToCharArray();

            for(int i = c.Length-1; i >= 0; i--)
            {
                sb.Append(c[i]);
            }
            sb.Append("\n");
        }
        Console.WriteLine(sb);
    }
}