using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split('/');
        int K = int.Parse(s[0]);
        int D = int.Parse(s[1]);
        int A = int.Parse(s[2]);
        if (K + A < D || D == 0) Console.WriteLine("hasu");
        else Console.WriteLine("gosu");
        
    }
}