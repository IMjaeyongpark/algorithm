using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        double a = double.Parse(s[0]);
        double b = double.Parse(s[1]);
        double c = double.Parse(s[2]);
        double d1 = a * b / c;
        double d2 = a / b * c;
        int d = d1 >= d2 ? (int)d1 : (int)d2;
        Console.WriteLine(d);
    }
}