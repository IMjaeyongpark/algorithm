using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(DateTime.Now.Year + "-" + $"{DateTime.Now.Month:D2}" + "-" + $"{DateTime.Now.Day:D2}");
    }
}