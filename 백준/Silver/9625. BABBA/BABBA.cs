using System;
using System.Text;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        for(int i = 1; i < N; i++)
        {
            int c = b;
            int d = a;
            b += d;
            a = c;
        }
        Console.WriteLine(a + " " + b);
    }
}