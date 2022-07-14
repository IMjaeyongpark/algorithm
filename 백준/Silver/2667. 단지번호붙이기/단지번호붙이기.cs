using System;
using System.Text;

class Program
{
    static char[,] a;
    static int N = 0;
    static int count = 0;
    static void dfs(int x,int y)
    {
        count++;
        a[x, y] = '0';
        if (x - 1 >= 0 && a[x - 1, y] == '1') dfs(x - 1, y);
        if (y - 1 >= 0 && a[x, y - 1] == '1') dfs(x, y - 1);
        if (x + 1 < N && a[x + 1, y] == '1') dfs(x + 1, y);
        if (y + 1 < N && a[x, y + 1] == '1') dfs(x, y + 1);
    }
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        List<int> list = new List<int>();
        N = int.Parse(Console.ReadLine());
        a = new char[N, N];
        for(int i = 0; i < N; i++)
        {
            char[] c = Console.ReadLine().ToCharArray();
            for(int j = 0; j < N; j++)
            {
                a[j, i] = c[j];
            }
        }
        for (int y1 = 0; y1 < N; y1++)
        {
            for (int x1 = 0; x1 < N; x1++)
            {
                if (a[x1, y1] == '1')
                {
                    count = 0;
                    dfs(x1, y1);
                    list.Add(count);
                }
            }
        }
        sb.Append(list.Count + "\n");
        list.Sort();
        for (int i = 0; i < list.Count; i++)
        {
            sb.Append(list[i] + "\n");
        }
        Console.WriteLine(sb.ToString());
    }
}