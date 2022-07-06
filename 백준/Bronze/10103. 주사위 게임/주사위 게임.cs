using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int a = 100;
        int b = 100;
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            int c = int.Parse(s[0]);
            int d = int.Parse(s[1]);
            if (c > d) b -= c;
            else if(c < d) a -= d;

        }
        Console.WriteLine(a + "\n" + b);
    }
}