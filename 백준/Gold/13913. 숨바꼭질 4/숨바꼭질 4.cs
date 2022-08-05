using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int K = int.Parse(s[1]);
        int[] visit = new int[100001];
        Queue<int> q = new Queue<int>();
        q.Enqueue(N);
        Dictionary<int, int> map = new Dictionary<int, int>();
        while (N != K && visit[K] == 0)
        {
            int x = q.Dequeue();
            if (x - 1 >= 0 && visit[x - 1] == 0)
            {
                visit[x - 1] = visit[x] + 1;
                q.Enqueue(x - 1);
                map.Add(x - 1, x);
            }
            if (x + 1 < visit.Length && visit[x + 1] == 0)
            {
                visit[x + 1] = visit[x] + 1;
                q.Enqueue(x + 1);
                map.Add(x + 1, x);
            }
            if (2 * x < visit.Length && visit[2 * x] == 0)
            {
                visit[2 * x] = visit[x] + 1;
                q.Enqueue(2 * x);
                map.Add(2 * x, x);
            }
        }
        Console.WriteLine(visit[K]);
        int[] root = new int[visit[K] + 1];
        root[visit[K]] = K;

        for (int i = root.Length - 2; i >= 0; i--)
        {
            root[i] = map[root[i + 1]];
        }
        foreach (var item in root) Console.Write(item + " ");
    }
}