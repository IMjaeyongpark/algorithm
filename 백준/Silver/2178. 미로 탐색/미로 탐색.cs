using System;

class Program
{
    static List<Queue<int>> qx = new List<Queue<int>>();
    static List<Queue<int>> qy = new List<Queue<int>>();
    static char[,] a;
    static int x,y;
    static void search(int i)
    {
        qx.Add(new Queue<int>());
        qy.Add(new Queue<int>());
        while (qx[i - 1].Count > 0)
        {
            int x1 = qx[i - 1].Dequeue();
            int y1 = qy[i - 1].Dequeue();
            if (x1 == x - 1 && y1 == y - 1) return;
            if (x1 - 1 >= 0 && a[x1 - 1, y1] == '1')
            {
                qx[i].Enqueue(x1 - 1);
                qy[i].Enqueue(y1);
                a[x1 - 1, y1] = '0';
            }
            if (y1 - 1 >= 0 && a[x1, y1 - 1] == '1')
            {
                qx[i].Enqueue(x1);
                qy[i].Enqueue(y1 - 1);
                a[x1, y1 - 1] = '0';
            }
            if (x1 + 1 < x && a[x1 + 1, y1] == '1')
            {
                qx[i].Enqueue(x1 + 1);
                qy[i].Enqueue(y1);
                a[x1 + 1, y1] = '0';
            }
            if (y1 + 1 < y && a[x1, y1 + 1] == '1')
            {
                qx[i].Enqueue(x1);
                qy[i].Enqueue(y1 + 1);
                a[x1, y1 + 1] = '0';
            }
        }
        search(++i);
    }

    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        x = int.Parse(s[1]);
        y = int.Parse(s[0]);
        a = new char[x, y];
        for (int i = 0; i < y; i++)
        {
            char[] c = Console.ReadLine().ToCharArray();
            for(int j =0; j < x; j++)
            {
                a[j, i] = c[j];
            }
        }
        qx.Add(new Queue<int>());
        qy.Add(new Queue<int>());
        qx[0].Enqueue(0);
        qy[0].Enqueue(0);
        search(1);
        Console.WriteLine(qx.Count-1);
    }
}