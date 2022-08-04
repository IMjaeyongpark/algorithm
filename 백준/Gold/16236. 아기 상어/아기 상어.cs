using System;

class Program
{
    static void Main()
    {
        int x = 0;
        int y = 0;
        int N = int.Parse(Console.ReadLine());
        int[,] sea = new int[N, N];
        int count = 0;
        int shark = 2;
        int eat = 0;
        int[] dx = { 0, -1, 1, 0 };
        int[] dy = { -1, 0, 0, 1 }; 
        for (int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            for (int j = 0; j < N; j++)
            {
                int a = int.Parse(s[j]);
                if (a == 9)
                {
                    x = j;
                    y = i;
                    a = 0;
                }
                sea[j, i] = a;
            }
        }

        bool check = false;
        do
        {
            Queue<int> x1 = new Queue<int>();
            Queue<int> y1 = new Queue<int>();
            Queue<int> eatx = new Queue<int>();
            Queue<int> eaty = new Queue<int>();
            x1.Enqueue(x);
            y1.Enqueue(y);
            int[,] visit = new int[N, N];
            check = false;
            if (eat == shark)
            {
                shark++;
                eat = 0;
            }
            while (x1.Count > 0)
            {
                int x2 = x1.Dequeue();
                int y2 = y1.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    if (x2 + dx[i] >= 0 && x2 + dx[i] < N && y2 + dy[i] >= 0 && y2 + dy[i] < N)
                    {
                        if (sea[x2 + dx[i], y2 + dy[i]] <= shark && visit[x2 + dx[i], y2 + dy[i]] == 0)
                        {
                            if (sea[x2 + dx[i], y2 + dy[i]] == 0 || sea[x2 + dx[i], y2 + dy[i]] == shark)
                            {
                                visit[x2 + dx[i], y2 + dy[i]] = visit[x2, y2] + 1;
                                x1.Enqueue(x2 + dx[i]);
                                y1.Enqueue(y2 + dy[i]);
                            }
                            else
                            {
                                visit[x2 + dx[i], y2 + dy[i]] = visit[x2, y2] + 1;
                                check = true;
                                eatx.Enqueue(x2 + dx[i]);
                                eaty.Enqueue(y2 + dy[i]);
                            }
                        }
                    }
                }
            }
            int minx = int.MaxValue;
            int miny = int.MaxValue;
            int min = int.MaxValue;
            while (eatx.Count > 0)
            {
                int x3 = eatx.Dequeue();
                int y3 = eaty.Dequeue();
                if (min > visit[x3, y3])
                {
                    min = visit[x3, y3];
                    minx = x3;
                    miny = y3;
                }
                else if (min == visit[x3, y3])
                {
                    if (miny > y3|| (miny == y3 && minx > x3))
                    {
                        min = visit[x3, y3];
                        minx = x3;
                        miny = y3;
                    }
                }
            }
            if (check)
            {
                x = minx;
                y = miny;
                sea[x, y] = 0;
                count += min;
                eat++;
            }
        } while (check);
        Console.WriteLine(count);
    }
}