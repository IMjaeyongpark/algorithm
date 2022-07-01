using System;

class Program
{
   
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int count = N / 3 + N % 3;
        string s = "SK";
        if (count % 2 == 0)
        {
            s = "CY";
        }
        Console.WriteLine(s);
    }
}
