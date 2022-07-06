using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            int r = int.Parse(s[0]);
            int e = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            if (e - r - c > 0) sb.Append("advertise\n");
            else if (e - r - c < 0) sb.Append("do not advertise\n");
            else sb.Append("does not matter\n");
        }
        Console.WriteLine(sb);
        
    }
}