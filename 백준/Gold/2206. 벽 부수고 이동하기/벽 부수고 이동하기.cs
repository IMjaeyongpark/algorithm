using System;

class Program
{
    class move
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public bool check { get; set; }
    }
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int x = int.Parse(s[1]);
        int y = int.Parse(s[0]);
        int[,] bfs = new int[x, y];
        int[,] no = new int[x, y];
        int[,] yes = new int[x, y];
        for(int i = 0; i < y; i++)
        {
            char[] c = Console.ReadLine().ToCharArray();
            for(int j = 0; j < x; j++)
            {
                bfs[j, i] = c[j] - '0';
            }
        }
        int[] dx = { 0, 0, 1, -1 };
        int[] dy = { 1, -1, 0, 0, };
        Queue<move> q = new Queue<move>();
        no[0, 0] = 1;
        q.Enqueue(new move() { x1 = 0, y1 = 0, check = false });
        while(q.Count > 0)
        {
            move tmp = q.Dequeue();
            for(int i = 0; i < 4; i++)
            {
                int nx = tmp.x1 + dx[i];
                int ny = tmp.y1 + dy[i];
                if (nx >= 0 && nx < x && ny >= 0 && ny < y)
                {
                    if (tmp.check)
                    {
                        if (bfs[nx, ny] == 0 && yes[nx, ny] == 0)
                        {
                            yes[nx, ny] = yes[tmp.x1, tmp.y1] + 1;
                            q.Enqueue(new move() { x1 = nx, y1 = ny, check = true });
                        }
                    }
                    else
                    {
                        if (bfs[nx, ny] == 0 && no[nx, ny] == 0)
                        {
                            no[nx, ny] = no[tmp.x1, tmp.y1] + 1;
                            q.Enqueue(new move() { x1 = nx, y1 = ny, check = false });
                        }
                        else if (bfs[nx, ny] == 1 && yes[nx, ny] == 0)
                        {
                            yes[nx, ny] = no[tmp.x1, tmp.y1] + 1;
                            q.Enqueue(new move() { x1 = nx, y1 = ny, check = true });
                        }
                    }
                }
            }
        }
        int cnt = yes[x - 1, y - 1];
        if (cnt == 0) cnt = no[x - 1, y - 1];
        else if (no[x - 1, y - 1] > 0 && no[x - 1, y - 1] < cnt) cnt = no[x - 1, y - 1];
        if (x != 1 && cnt == 0) cnt = -1;
        Console.WriteLine(cnt);
    }
}