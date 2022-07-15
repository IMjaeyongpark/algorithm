using System;
using System.Text;

class Program
{
    public struct xy
    {
        public int x;
        public int y;
    }
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        xy[] xys = new xy[N];
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            xys[i].x = int.Parse(s[0]);
            xys[i].y = int.Parse(s[1]);
        }
        var a = xys.OrderBy(x => x.y).ThenBy(x => x.x);
        foreach (var b in a) sb.Append(b.x + " " + b.y + "\n");
        Console.WriteLine(sb);
    }
}