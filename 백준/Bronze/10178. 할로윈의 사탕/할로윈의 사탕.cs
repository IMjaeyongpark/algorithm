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
            sb.Append("You get " + (int.Parse(s[0]) / int.Parse(s[1]))+ " piece(s) and your dad gets " + (int.Parse(s[0]) % int.Parse(s[1])) + " piece(s).\n");
        }
        Console.WriteLine(sb);
    }
}