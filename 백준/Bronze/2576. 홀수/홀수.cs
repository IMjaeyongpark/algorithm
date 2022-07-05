using System;

class Program
{
    static void Main()
    {
        int min = int.MaxValue;
        int sum = 0;

        for(int i = 0; i < 7; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 != 0)
            {
                sum += a;
                if (min > a) min = a;
            }
        }
        if (sum == 0) Console.WriteLine(-1);
        else Console.WriteLine(sum + "\n" + min);
    }
}