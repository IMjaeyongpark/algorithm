using System;
using System.Text;

class Program
{

    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] s = Console.ReadLine().Split();
        int N =int.Parse(s[0]);
        int K = int.Parse(s[1]);
        int[] a = new int[N];
        int count = 0;
        int c = -1;
        while (count < N)
        {

            int b = 0;
            while (b < K)
            {
                c++;
                if (a[c % N] == 0) b++;
            }
            if (count == 0) sb.Append("<" + (c % N + 1));
            else sb.Append(", " + (c % N + 1));
            count++;
            a[c % N]++;
        }
        Console.WriteLine(sb + ">");
    }
}