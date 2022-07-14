using System;
using System.Text;

class Program
{
    public struct xy {
        public int x;
        public int y;
    }
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        xy[] a = new xy[N];
        for(int i = 0; i < N; i++)
        {
            string[] s  = Console.ReadLine().Split();
            a[i].x = int.Parse(s[0]);
            a[i].y = int.Parse(s[1]);
        }
        var list = a.OrderBy(x => x.x).ThenBy(y => y.y);
        foreach(var item in list)
        {
            sb.Append(item.x + " " + item.y + "\n");
        }
        Console.WriteLine(sb);
    }
}