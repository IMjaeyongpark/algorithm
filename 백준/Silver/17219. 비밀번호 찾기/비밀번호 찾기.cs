using System;
using System.Text;
using System.Collections.Generic;


class Program
{

    static void Main()
    {
        StringBuilder sb = new StringBuilder();
       
        string[] n = Console.ReadLine().Split();
        int N = int.Parse(n[0]);
        int M = int.Parse(n[1]);
        Dictionary<string, string> dic = new Dictionary<string, string>();
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            dic.Add(s[0], s[1]);
        }
        for (int i = 0; i < M; i++)
        {
            string e = Console.ReadLine();
            sb.Append(dic[e] + "\n");
        }
        Console.WriteLine(sb);
    }
}