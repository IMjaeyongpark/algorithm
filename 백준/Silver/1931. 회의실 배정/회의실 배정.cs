using System;

class Program
{
    struct time
    {
        public int start;
        public int end;
    }
    static void Main()
    {
        int count = 1;
        int N = int.Parse(Console.ReadLine());
        time[] t = new time[N];

        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            t[i].start = int.Parse(s[0]);
            t[i].end = int.Parse(s[1]);
        }
        t = t.OrderBy(x => x.end).ThenBy(x=>x.start).ToArray();
        int end = t[0].end;
        for(int i = 1; i < N; i++)
        {
            if (end <= t[i].start)
            {
                count++;
                end = t[i].end;
            }
        }
        Console.WriteLine(count);
    }
}