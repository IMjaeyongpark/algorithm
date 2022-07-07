using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int a = int.Parse(Console.ReadLine());
        for(int i = 0; i < a; i++)
        {
            int count = 0;
            string[] s1 = Console.ReadLine().Split();
            int N = int.Parse(s1[0]);
            int K = int.Parse(s1[1]);
            string[] s2 = Console.ReadLine().Split();
            for(int j = 0; j < N; j++)
            {
                count += int.Parse(s2[j]) / K;
            }
            sb.Append(count + "\n");
        }
        Console.WriteLine(sb);
    }
}