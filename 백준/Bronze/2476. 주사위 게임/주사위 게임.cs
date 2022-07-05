using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int M = 0;
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);

            if (a == b && b == c)
            {
                sum = 10000 + a * 1000;
            }
            else if (a == b || b == c || a == c)
            {
                if (a == b || a == c)
                {
                    sum = 1000 + a * 100;
                }
                else sum = 1000 + b * 100;
            }
            else
            {
                int max = a >= b ? a : b;
                max = max >= c ? max : c;
                sum = max * 100;
            }
            if (M < sum) M = sum;
        }
        Console.WriteLine(M);
    }
}