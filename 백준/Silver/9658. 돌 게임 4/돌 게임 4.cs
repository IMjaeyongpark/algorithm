using System;

class Program
{
    static void Main()
    {
        int N =int.Parse(Console.ReadLine());
        Console.WriteLine((N % 7 == 1 || N % 7 == 3) ? "CY" : "SK");
    }
}