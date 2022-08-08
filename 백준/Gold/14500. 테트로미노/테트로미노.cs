using System;

class Program
{
    static int max = int.MinValue;
    static int x;
    static int y;
    static int[,] tt;
    static void search(int x1, int y1, int count, int score,int check)
    {
        int[] dx = { 0, 1, 0, -1 };
        int[] dy = { 1, 0, -1, 0 };
        if (count == 0)
        {
            int tmp = tt[x1, y1];
            for(int i = 0; i < 4; i++)
            {
                int nx = x1 + dx[i];
                int ny = y1 + dy[i];
                if (nx >= 0 && nx < x && ny >= 0 && ny < y) tmp += tt[nx, ny];
            }
            for (int i = 0; i < 4; i++)
            {

                int temp = tmp;
                int nx = x1 + dx[i];
                int ny = y1 + dy[i];
                if (nx >= 0 && nx < x && ny >= 0 && ny < y)
                {
                    temp = tmp - tt[nx, ny];
                }
                if (max < temp) max = temp;
            }
        }
        score += tt[x1, y1];
        if (count == 3)
        {
            if (max < score) max = score;
            return;
        }
        for(int i = 0; i < 4; i++)
        {
            int nx = x1 + dx[i];
            int ny = y1 + dy[i];
            if (nx < x && nx >= 0 && ny < y && ny >= 0)
            {
                if (i == 0)
                {
                    if (check != 2) search(nx, ny, count + 1, score, 1);
                }
                else if (i == 2)
                {
                    if (check != 1) search(nx, ny, count + 1, score, 2);
                }
                else if (i == 1)
                {
                    if(check != 0)
                    search(nx, ny, count + 1, score, 4);
                }
                else 
                {
                    if (check != 4)
                        search(nx, ny, count + 1, score, 0);
                }
            }
        }
    }
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        x = int.Parse(s[1]);
        y = int.Parse(s[0]);
        tt = new int[x, y];
        for (int i = 0; i < y; i++)
        {
            string[] c = Console.ReadLine().Split();
            for (int j = 0; j < x; j++)
            {
                tt[j, i] = int.Parse(c[j]);
            }
        }
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                search(j, i, 0, 0, 0);
            }
        }
        Console.WriteLine(max);
    }
}