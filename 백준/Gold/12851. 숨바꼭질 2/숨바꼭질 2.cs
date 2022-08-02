using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int K = int.Parse(s[1]);
        int[] visit = new int[100001];
        int[] check = new int[100001];
        Queue<int> q = new Queue<int>();
        q.Enqueue(N);
        check[N]++;
        while (N != K && q.Count > 0)
        {
            int x = q.Dequeue();
            if (x - 1 >= 0 && (check[x - 1] == 0 || visit[x - 1] == visit[x] + 1))
            {
                check[x - 1] += check[x];
                if (visit[x - 1] == 0)
                {
                    q.Enqueue(x - 1);
                    visit[x - 1] = visit[x] + 1;
                }
            }
            if (x + 1 < visit.Length && (check[x + 1] == 0 || visit[x + 1] == visit[x] + 1))
            {
                check[x + 1] += check[x];
                if (visit[x + 1] == 0)
                {
                    q.Enqueue(x + 1);
                    visit[x + 1] = visit[x] + 1;
                }

            }
            if (2 * x < visit.Length && (check[2 * x] == 0 || visit[2 * x] == visit[x] + 1))
            {
                check[x * 2] += check[x];
                if (visit[x * 2] == 0)
                {
                    q.Enqueue(2 * x);
                    visit[2 * x] = visit[x] + 1;
                }
            }
        }
        Console.WriteLine(visit[K] + "\n" + check[K]);
    }
}