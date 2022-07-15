using System;

class Program
{
    static int x,y;
    static int[,] box;
    static int tomato = 0;
    static List<Queue<int>> xs = new List<Queue<int>>();
    static List<Queue<int>> ys = new List<Queue<int>>();
    static void search(int i)
    {
        xs.Add(new Queue<int>());
        ys.Add(new Queue<int>());
        while (xs[i].Count > 0)
        {
            int x1 = xs[i].Dequeue();
            int y1 = ys[i].Dequeue();
            if (x1 - 1 >= 0 && box[x1 - 1, y1] == 0)
            {
                box[x1 - 1, y1] = 1;
                xs[i + 1].Enqueue(x1 - 1);
                ys[i + 1].Enqueue(y1);
                tomato++;
            }
            if (x1 + 1 < x && box[x1 + 1, y1] == 0)
            {
                box[x1 + 1, y1] = 1;
                xs[i + 1].Enqueue(x1 + 1);
                ys[i + 1].Enqueue(y1);
                tomato++;
            }
            if (y1 - 1 >= 0 && box[x1, y1 - 1] == 0)
            {
                box[x1, y1 - 1] = 1;
                xs[i + 1].Enqueue(x1);
                ys[i + 1].Enqueue(y1 - 1);
                tomato++;
            }
            if (y1 + 1 < y && box[x1, y1 + 1] == 0)
            {
                box[x1, y1 + 1] = 1;
                xs[i + 1].Enqueue(x1);
                ys[i + 1].Enqueue(y1 + 1);
                tomato++;
            }
        }
    }

    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        x = int.Parse(s[0]);
        y = int.Parse(s[1]);
        box = new int[x,y];
        int to = 0;

        for (int i = 0; i < y; i++)
        {
            string[] s2 = Console.ReadLine().Split();
            for(int j = 0; j < x; j++)
            {
                box[j, i] = int.Parse(s2[j]);
                if (box[j, i] == 0) to++;
            }
        }
        xs.Add(new Queue<int>());
        ys.Add(new Queue<int>());
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                if (box[j, i] == 1)
                {
                    xs[0].Enqueue(j);
                    ys[0].Enqueue(i);
                }
            }
        }
        for (int i = 0; true; i++)
        {
            if (to == tomato) break;
            search(i);
            if (xs[i + 1].Count == 0)
            {
                xs.Clear();break;
            }
        }
        Console.WriteLine(xs.Count - 1);
    }
}