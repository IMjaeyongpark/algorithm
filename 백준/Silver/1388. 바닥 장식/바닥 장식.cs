using System;

class Program
{
    static char[,] c;
    static int x1,y1;
    static void dfs1(int x,int y)
    {
        c[x, y] = '0';
        if (x + 1 < x1 && c[x + 1, y] == '-') dfs1(x + 1, y);
    }
    static void dfs2(int x, int y)
    {
        c[x, y] = '0';
        if (y + 1 < y1 && c[x, y + 1] == '|') dfs2(x, y + 1);
    }
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        y1 = int.Parse(s[0]);
        x1 = int.Parse(s[1]);
        c = new char[x1, y1];
        for(int i = 0; i < y1; i++)
        {
            char[] a = Console.ReadLine().ToCharArray();
            for(int j = 0; j < x1; j++)
            {
                c[j, i] = a[j];
            }
        }
        int cnt = 0;
        for (int i = 0; i < y1; i++)
        {
            for (int j = 0; j < x1; j++)
            {
                if (c[j,i]== '-')
                {
                    cnt++;
                    dfs1(j, i);
                }
                if (c[j, i] == '|')
                {
                    cnt++;
                    dfs2(j, i);
                }
            }
        }
        Console.WriteLine(cnt);
    }
}
