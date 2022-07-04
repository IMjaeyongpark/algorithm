using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (N % 10 != 0) Console.WriteLine(-1);
        else
        {
            int m5 = N/300;
            N-= m5*300;
            int m1 = N/60;
            N -= m1 * 60;
            int s10 = N/10;

            Console.WriteLine(m5 + " " + m1 + " " + s10);
        }
    }
}