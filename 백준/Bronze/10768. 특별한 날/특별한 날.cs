using System;

class Program
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        string s = "";
        if (M < 2) s = "Before";
        else if (M > 2) s = "After";
        else
        {
            if (D == 18) s = "Special";
            else if (D > 18) s = "After";
            else if (D < 18) s = "Before";
        }
        Console.WriteLine(s);
    }
}