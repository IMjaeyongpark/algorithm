using System;

class Program
{
    static void Main()
    {
        int count = 0;
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            if (int.Parse(Console.ReadLine()) == 1) count++;
        }
        if (N / 2 < count) Console.WriteLine("Junhee is cute!");
        else Console.WriteLine("Junhee is not cute!");
    }
}