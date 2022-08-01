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
        visit[N] = 1;
        while (N != K && visit[K] == 0)
        {
            int x = q.Dequeue();
            if (2 * x < visit.Length && visit[2 * x] == 0)
            {
                visit[2 * x] = visit[x];
                q.Enqueue(2 * x);
            }
            if (x - 1 >= 0 && visit[x - 1] == 0)
            {
                visit[x - 1] = visit[x] + 1;
                q.Enqueue(x - 1);
            }
            if (x + 1 < visit.Length && visit[x + 1] == 0)
            {
                visit[x + 1] = visit[x] + 1;
                q.Enqueue(x + 1);
            }
        }
        Console.WriteLine(visit[K] - 1);
    }
}