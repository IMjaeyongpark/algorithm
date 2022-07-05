using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        string s1 = "";
        if (M < 3) s1 = "NEWBIE!";
        else if (M <= N) s1 = "OLDBIE!";
        else s1 = "TLE!";
        Console.WriteLine(s1);
    }
}