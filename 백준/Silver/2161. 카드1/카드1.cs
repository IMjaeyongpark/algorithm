using System;
using System.Text;

class Program
{
    
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        int[] a = new int[N];
        int count = 0;
        int c = 0;
        while (count < N)
        {
            sb.Append((c % N + 1) + " ");
            count++;
            a[c % N]++;
            if (count >= N) break;
            while (a[c % N] == 1) c++;
            c++;
            while (a[c % N] == 1) c++;
        }
        Console.WriteLine(sb);
    }
}