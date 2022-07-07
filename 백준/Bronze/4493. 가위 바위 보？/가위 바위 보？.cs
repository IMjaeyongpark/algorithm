using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            int[] a = new int[2];
            int m = int.Parse(Console.ReadLine());
            for(int j = 0; j < m; j++)
            {
                string[] s = Console.ReadLine().Split();
                if (s[0] != s[1])
                {
                    if(s[0] == "R")
                    {
                        if (s[1] == "S") a[0]++;
                        else a[1]++;
                    }
                    else if (s[0] == "S")
                    {
                        if (s[1] == "P") a[0]++;
                        else a[1]++;
                    }
                    else if (s[0] == "P")
                    {
                        if (s[1] == "R") a[0]++;
                        else a[1]++;
                    }
                }
            }
            if (a[0] > a[1]) sb.Append("Player 1\n");
            else if (a[1] > a[0]) sb.Append("Player 2\n");
            else sb.Append("TIE\n");
        }
        Console.WriteLine(sb);
    }
}