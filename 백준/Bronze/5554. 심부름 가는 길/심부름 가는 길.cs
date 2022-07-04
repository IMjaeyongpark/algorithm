using System;

class Program
{
    static void Main()
    {

        int S = 0;
        for(int i = 0; i < 4; i++)
        {
            S += int.Parse(Console.ReadLine());
        }
        int M = S / 60;
        S %= 60;
        Console.WriteLine(M + "\n" + S);

        
    }
}