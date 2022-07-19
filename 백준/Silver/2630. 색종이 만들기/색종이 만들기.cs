using System;

class Program
{
    static int[,] paper;
    static int[] count = new int[2];
    static void cut(int x, int y, int N)
    {
        int a = paper[x, y];
        bool check = true;
        for (int y1 = 0; y1 < N; y1++)
        {
            for (int x1 = 0; x1 < N; x1++)
            {
                if (paper[x1 + x, y1 + y] != a)
                {
                    for (int y2 = 0; y2 < N; y2 += N / 2)
                    {
                        for (int x2 = 0; x2 < N; x2 += N / 2)
                        {
                            cut(x2 + x, y2 + y, N / 2);
                        }
                    }
                    check = false;
                    break;
                }
            }
            if (!check) break;
        }
        if (check) count[a]++;
    }
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        paper = new int[N, N];
        for (int y = 0; y < N; y++)
        {
            string[] s = Console.ReadLine().Split();
            for (int x = 0; x < N; x++)
            {
                paper[x, y] = int.Parse(s[x]);
            }
        }
        cut(0, 0, N);
        Console.WriteLine(count[0]);
        Console.WriteLine(count[1]);
    }
}