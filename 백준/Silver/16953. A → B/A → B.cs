using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        var check = new Dictionary<int, int>();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        check.Add(N, 1);
        Queue<int> q = new Queue<int>();
        q.Enqueue(N);
        while (!check.ContainsKey(M) && q.Count > 0)
        {
            int x = q.Dequeue();
            int nx = x * 2;
            if (!check.ContainsKey(nx) && nx <= M && nx > 0)
            {
                check.Add(nx, check[x] + 1);
                q.Enqueue(nx);
            }
            string tmp = x.ToString();
            tmp += "1";
            try
            {
                nx = int.Parse(tmp);
                if (!check.ContainsKey(nx) && nx <= M && nx > 0)
                {
                    check.Add(nx, check[x] + 1);
                    q.Enqueue(nx);
                }
            }
            catch { }
            
        }
        if (check.ContainsKey(M)) Console.WriteLine(check[M]);
        else Console.WriteLine(-1);
    }
}