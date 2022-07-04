using System;

class Program
{
    static void Main()
    {
 
        string s = "";
        int[] a = { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
        int sum = a[0] + a[1] + a[2];

        if (sum != 180) s = "Error";
        else
        {
            if (a[0] == a[1] && a[1] == a[2]) s = "Equilateral";
            else if (a[0] == a[1] || a[1] == a[2] || a[0] == a[2]) s = "Isosceles";
            else s = "Scalene";
        }
        Console.WriteLine(s);
    }
}