using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            char[] s = Console.ReadLine().ToCharArray();
            Console.WriteLine(s[0] + "" + s[s.Length - 1]);
        }
    }
}