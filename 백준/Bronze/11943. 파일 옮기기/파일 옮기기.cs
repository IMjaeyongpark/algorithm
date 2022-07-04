using System;

class Program
{
    static void Main()
    {
        string[] s1 = Console.ReadLine().Split();
        string[] s2 = Console.ReadLine().Split();

        int a = int.Parse(s1[0]);
        int b = int.Parse(s1[1]);
        int c = int.Parse(s2[0]);
        int d = int.Parse(s2[1]);

        int hap = a + d >= b + c ? b + c : a + d;
        Console.WriteLine(hap);
    }
}