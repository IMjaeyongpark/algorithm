using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int T = int.Parse(Console.ReadLine());
        int[] a = new int[14];

        for(int i = 0; i < T; i++)
        {
            for (int j = 0; j < 14; j++) a[j] = j + 1;
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for(int j = 0; j < k-1; j++)
            {
                for(int q=1; q<n; q++)
                {
                    a[q] += a[q - 1];
                }
            }
            int sum = 0;
            for (int j = 0; j < n; j++) sum += a[j];
            sb.Append(sum + "\n");
        }
        Console.WriteLine(sb);
    }
}