using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int check = 1;
        if (N % 2 == 0 || N == 1)
        {
            while (N != 1)
            {
                if (N % 2 != 0)
                {
                    check = 0;
                    break;
                }
                N /= 2;
            }
        }
        else check = 0;
        Console.WriteLine(check);
    }
}