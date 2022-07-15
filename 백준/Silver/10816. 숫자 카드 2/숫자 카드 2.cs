using System;
using System.Text;

class Program
{

    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] card = new int[20000001];
        int N = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();
        for(int i = 0; i < N; i++)
        {
            card[int.Parse(s[i]) + 10000000]++;
        }

        int M = int.Parse(Console.ReadLine());
        string[] s1 = Console.ReadLine().Split();
        for(int j = 0; j < M; j++)
        {
            sb.Append(card[int.Parse(s1[j]) + 10000000] + " ");
        }
        Console.WriteLine(sb);
    }
}