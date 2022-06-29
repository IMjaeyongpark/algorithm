using System;
using System.Text;

class Program
    {
        static void Main(string[] agrs)
        {
            StringBuilder sb = new StringBuilder();
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            char temp;
            for (int i = 0; i < c.Length-1; i++)
            {
                for (int j = i; j >= 0 && c[j] < c[j + 1]; j--)
                {
                    temp = c[j];
                    c[j] = c[j + 1];
                    c[j + 1] = temp;
                }
            }
            foreach (char c2 in c)
            {
                sb.Append(c2);
            }
            Console.WriteLine(sb);
        }
    }