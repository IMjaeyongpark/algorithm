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
            int V = int.Parse(s[0]);
            int E = int.Parse(s[1]);
            int a = 2 + E - V;
            sb.Append(a + "\n");
        }
        Console.WriteLine(sb);
    }
}