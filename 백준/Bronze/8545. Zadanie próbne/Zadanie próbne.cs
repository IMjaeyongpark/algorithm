using System;

class Program
{
    static void Main()
    {
        char[] s = Console.ReadLine().ToCharArray();
        for(int i = s.Length-1; i >= 0; i--)
        {
            Console.Write(s[i]);
        }
    }
}