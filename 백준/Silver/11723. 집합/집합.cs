using System;
using System.Text;


class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        int[] a = new int[21];
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            if (s[0] == "add")
            {
                a[int.Parse(s[1])] = 1;
            }
            else if (s[0] == "remove")
            {
                a[int.Parse(s[1])] = 0;
            }
            else if (s[0] == "check")
            {
                sb.Append(a[int.Parse(s[1])] + "\n");
            }
            else if (s[0] == "toggle")
            {
                int b = int.Parse(s[1]);
                if (a[b] == 0) a[b] = 1;
                else a[b] = 0;
            }
            else if (s[0] == "all")
            {
                for (int j = 1; j < 21; j++) a[j] = 1;
            }
            else if (s[0] == "empty")
            {
                a = new int[21];
            }
        }
        Console.WriteLine(sb);
    }
}