using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int n1 = int.Parse(s[0]);
        int n2 = int.Parse(s[1]);
        int n3 = int.Parse(s[2]);

        Console.WriteLine((n1+1)*(n2+1)/(n3+1)-1);
    }
}