using System;

class Program
{
    static void Main()
    {
        char[] c = Console.ReadLine().ToCharArray();
        if (c[0] == 'N' || c[0] == 'n')
        {
            Console.WriteLine("Naver D2");
        }
        else Console.WriteLine("Naver Whale");
    }
}