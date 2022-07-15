using System;

class Program
{
    
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int m = int.Parse(s[1]);
        int[] a = new int[N];
        int count = 0;

        for(int i=0; i < N; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        for(int i = N - 1; m > 0; i--)
        {
            if (a[i] <= m)
            {

                count += m / a[i];
                m -= a[i] * (m / a[i]);
            }
        }
        Console.WriteLine(count);
    }
}