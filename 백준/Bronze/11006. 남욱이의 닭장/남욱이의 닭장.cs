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
            int a = 2 * int.Parse(s[1]) - int.Parse(s[0]);
            int b = int.Parse(s[0]) - int.Parse(s[1]);
            sb.Append(a + " " + b + "\n");
        }
        Console.WriteLine(sb);
    }
}