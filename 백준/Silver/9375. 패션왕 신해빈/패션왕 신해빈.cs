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
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int M = int.Parse(Console.ReadLine());
            for(int j = 0; j < M; j++)
            {
                string[] s = Console.ReadLine().Split();
                if (dic.ContainsKey(s[1])) dic[s[1]]++;
                else
                {
                    dic.Add(s[1], 1);
                }
            }
            int sum = 1;
            foreach(string s in dic.Keys)
            {
                sum *= (dic[s] + 1);
            }
            sb.Append(sum - 1 + "\n");
        }
        Console.WriteLine(sb);
    }
}