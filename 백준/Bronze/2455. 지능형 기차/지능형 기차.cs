using System;

class Program
{
    static void Main()
    {
        int P = 0;
        int max = int.MinValue;
        for(int i = 0; i < 4; i++)
        {
            string[] s = Console.ReadLine().Split();
            P += int.Parse(s[1]) - int.Parse(s[0]);
            if (max < P) max = P;
        }
        Console.WriteLine(max);
    }
}