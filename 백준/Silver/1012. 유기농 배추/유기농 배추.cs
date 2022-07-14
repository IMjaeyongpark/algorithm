using System;
using System.Text;

class Program
{
    static int[,] a = new int[50,50];
    static void dfs(int x,int y)
    {
        a[y, x] = 0;
        if (x - 1 >= 0 && a[y, x - 1] == 1) dfs(x - 1, y);
        if (x + 1 < 50 && a[y, x + 1] == 1) dfs(x + 1, y);
        if (y - 1 >= 0 && a[y - 1, x] == 1) dfs(x, y - 1);
        if (y + 1 < 50 && a[y + 1, x] == 1) dfs(x, y + 1);
        return;
    }
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < T; i++)
        {
            string[] s = Console.ReadLine().Split();
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);
            int k = int.Parse(s[2]);

            for (int j = 0; j < k; j++)
            {
                string[] s1 = Console.ReadLine().Split();
                int x1 = int.Parse(s1[0]);
                int y1 = int.Parse(s1[1]);
                a[y1, x1] = 1;
            }
            int count = 0;

            for (int y2 = 0; y2 < y; y2++)
            {
                for (int x2 = 0; x2 < x; x2++)
                {
                    if(a[y2, x2] == 1){
                        dfs(x2, y2);
                        count++;
                    }
                    
                }
            }
            
            sb.Append(count + "\n");
            
        }
        Console.WriteLine(sb);
    }
}
