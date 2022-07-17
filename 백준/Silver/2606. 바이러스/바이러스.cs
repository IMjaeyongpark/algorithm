using System;

class Program
{
   
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        var com = new List<Queue<int>>();
        var save = new Queue<int>();
        var save1 = new Queue<int>();
        int[] vi = new int[N + 1];
        int count = 0;
        vi[1]++;
        for (int i = 0; i <= N; i++) com.Add(new Queue<int>());
        for(int i = 0; i < M; i++)
        {
            string[] s = Console.ReadLine().Split();
            com[int.Parse(s[0])].Enqueue(int.Parse(s[1]));
            com[int.Parse(s[1])].Enqueue(int.Parse(s[0]));
        }
        while (com[1].Count > 0)
        {
            int a = com[1].Dequeue();
            if (vi[a] == 0)
            {
                vi[a]++;
                save.Enqueue(a);
                count++;
            }
        }
        while(save.Count > 0)
        {
            int a = save.Dequeue();
            while (com[a].Count > 0)
            {
                int b = com[a].Dequeue();
                if (vi[b] == 0)
                {
                    vi[b]++;
                    save1.Enqueue(b);
                    count++;
                }
            }
            if (save1.Count > 0)
            {
                save.Enqueue(save1.Dequeue());
            }
        }
        Console.WriteLine(count);
    }
}