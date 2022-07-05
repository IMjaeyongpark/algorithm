using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int c = int.Parse(s[2]);
        string s1 = "";
        string s2 = "";

      
            if (a - b == c)
            {
                s1 = "-";
                s2 = "=";
            }
            else if (a / b == c)
            {
                s1 = "/";
                s2 = "=";
            }
            else if (b + c == a)
            {
                s1 = "=";
                s2 = "+";
            }
            else if (b * c == a)
            {
                s1 = "=";
                s2 = "*";
            }
      
            else if (a + b == c)
            {
                s1 = "+";
                s2 = "=";
            }
            else if (a * b == c)
            {
                s1 = "*";
                s2 = "=";
            }
            else if (b - c == a)
            {
                s1 = "=";
                s2 = "-";
            }
            else if (b / c == a)
            {
                s1 = "=";
                s2 = "/";
            }
        
        Console.WriteLine(a + s1 + b + s2 + c);
    }
}