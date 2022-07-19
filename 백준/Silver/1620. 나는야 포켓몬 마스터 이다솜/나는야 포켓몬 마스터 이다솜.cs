using System;
using System.Text;


class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        Dictionary<string, int> map = new Dictionary<string, int>();
        string[] pok = new string[N];
        for(int i = 0; i < N; i++)
        {
            string po = Console.ReadLine();
            map.Add(po, i + 1);
            pok[i] = po;
        }
        for(int i = 0; i < M; i++)
        {
            string po = Console.ReadLine();
            if (map.ContainsKey(po))
            {
                sb.Append(map[po] + "\n");
            }
            else
            {
                int a = int.Parse(po);
                sb.Append(pok[a - 1] + "\n");
            }
        }
        Console.WriteLine(sb.ToString());
    }
}