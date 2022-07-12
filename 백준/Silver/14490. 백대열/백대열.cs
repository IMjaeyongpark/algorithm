using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split(":");
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int c = 0;
        if (a >= b) c = b;
        else c = a;
        for(int i = 2; i <= c; i++)
        {
            while(a%i==0&& b % i == 0)
            {
                a /= i;
                b /= i;
                c /= i;
            }
        }
        Console.WriteLine(a + ":" + b);
    }
}