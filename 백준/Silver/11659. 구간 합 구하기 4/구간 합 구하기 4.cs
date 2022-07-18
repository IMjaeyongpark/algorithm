using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[1]);
        string[] n = Console.ReadLine().Split();
        int[] sum = new int[int.Parse(s[0])+1];
        for(int i = 1; i < sum.Length; i++)
        {
            sum[i] = sum[i - 1] + int.Parse(n[i - 1]);
        }
        for(int j = 0; j < N; j++)
        {
            int sum1 = 0;
            string[] s1 = Console.ReadLine().Split();
            sum1 = sum[int.Parse(s1[1])] - sum[int.Parse(s1[0]) - 1];
            sb.Append(sum1 + "\n");
        }
        Console.WriteLine(sb);
    }
}