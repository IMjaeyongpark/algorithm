using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        char[] s = Console.ReadLine().ToCharArray();
        Stack<char> St = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                while (St.Count > 0) sb.Append(St.Pop());
                sb.Append(" ");
            }
            else if (s[i] == '<')
            {
                while (St.Count > 0) sb.Append(St.Pop());
                while (s[i] != '>')
                {
                    sb.Append(s[i]);
                    i++;
                }
                sb.Append(s[i]);
            }
            else St.Push(s[i]);
        }
        while (St.Count > 0) sb.Append(St.Pop());
        Console.Write(sb);
    }
}