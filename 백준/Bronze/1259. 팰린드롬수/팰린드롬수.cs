using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string s = "yes";
            char[] c = Console.ReadLine().ToCharArray();
            if (c[0] == '0') break;
            for(int i = 0; i < c.Length/2; i++)
            {
                if (c[i] != c[c.Length - i - 1])
                {
                    s = "no";
                    break;
                }
            }
            sb.Append(s + "\n");
        }
        Console.WriteLine(sb.ToString());
    }
}
