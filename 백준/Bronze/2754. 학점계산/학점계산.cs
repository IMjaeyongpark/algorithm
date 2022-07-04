using System;
using System.Text;

class Program
{
    static void Main()
    {
        char[] s = Console.ReadLine().ToCharArray();
        double a = 'E';
        a -= s[0];

        if (s[0] == 'F') a =0;
        else if (s[1] == '-') a -= 0.3;
        else if (s[1] == '+') a += 0.3;


        Console.WriteLine($"{a:0.0}");
    }
}