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
            sb.Append("Hello World, Judge " + (i + 1) + "!\n");
        }
        Console.WriteLine(sb);
    }
}