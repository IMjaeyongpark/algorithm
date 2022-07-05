using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            int sum = 1;
            char[] s = Console.ReadLine().ToCharArray();
            if (s[0] == '0') break;
            for(int i = 0; i < s.Length; i++)
            {
                int a = s[i] - '0';
                if (a == 1) sum += 3;
                else if (a == 0) sum += 5;
                else sum += 4;
            }
            sb.Append(sum + "\n");
        }
        Console.WriteLine(sb);
    }
}