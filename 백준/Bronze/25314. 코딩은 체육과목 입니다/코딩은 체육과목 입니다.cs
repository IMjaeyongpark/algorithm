using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N / 4; i++)
        {
            Console.Write("long ");
        }
        Console.Write("int");
    }
}