using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        long a = long.Parse(s[0]);
        long b = long.Parse(s[1]);
        long sum=0;

        if ((a < 0 && b < 0) || (a > 0 && b > 0))
        {
            sum = a - b;
            if (sum < 0)
            {
                sum *= -1;
            }
        }
        else
        {
            sum = a - b;
            if (sum < 0)
            {
                sum *= -1;
            }
        }
        Console.WriteLine(sum);
    }
}