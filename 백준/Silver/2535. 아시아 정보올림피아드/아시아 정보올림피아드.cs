using System;
using System.Text;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] g = new int[3];
        int[] s = new int[3];
        int[] d = new int[3];
        

        for (int i = 0; i < N; i++)
        {
            string[] s1 = Console.ReadLine().Split();
            if (int.Parse(s1[2]) > g[2])
            {
                if (g[0] != s[0] || s[0] != int.Parse(s1[0]))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        d[j] = s[j];
                        s[j] = g[j];
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        g[j] = int.Parse(s1[j]);
                    }
                }
                else
                {
                    for (int j = 0; j < 3; j++)
                    {
                        s[j] = g[j];
                        g[j] = int.Parse(s1[j]);
                    }
                }
            }
            else if (int.Parse(s1[2]) > s[2])
            {
                if (g[0] != s[0] || s[0] != int.Parse(s1[0]))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        d[j] = s[j];
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        s[j] = int.Parse(s1[j]);
                    }
                }
                else
                {
                    for (int j = 0; j < 3; j++)
                    {
                        s[j] = int.Parse(s1[j]);
                    }
                }
            }
            else if (int.Parse(s1[2]) > d[2])
            {
                if(g[0] != s[0] || s[0] != int.Parse(s1[0]))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        d[j] = int.Parse(s1[j]);
                    }
                }
            }
            
        }
        Console.WriteLine(g[0] + " " + g[1]);
        Console.WriteLine(s[0] + " " + s[1]);
        Console.WriteLine(d[0] + " " + d[1]);

    }
}