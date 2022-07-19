using System;


class Program
{
    static void Main()
    {
        Dictionary<string ,int> dic = new Dictionary<string ,int>();
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int count = 0;
        for(int i = 0; i < N; i++)
        {
            dic.Add(Console.ReadLine(), 0);
        }
        for(int j = 0; j < M; j++)
        {
            string s1 = Console.ReadLine();
            if (dic.ContainsKey(s1)) count++;
        }
        Console.WriteLine(count);
    }
}