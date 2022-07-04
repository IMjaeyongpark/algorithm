using System;

class Program
{
    static void Main()
    {
        int L = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int M1 = int.Parse(Console.ReadLine());
        int K1 = int.Parse(Console.ReadLine());

        int day = 0;
        if(M / M1 == K / K1)
        {
            day = M / M1;
            if (M % M1 != 0 || K % K1 != 0) day++;
        }
        else if (M / M1 > K / K1)
        {
            day = M / M1 ;
            if (M % M1 != 0) day++;
        }
        else
        {
            day = K / K1;
            if (K % K1 != 0) day++;
        }
        Console.WriteLine(L-day);

    }
}