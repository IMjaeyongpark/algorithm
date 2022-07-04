using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        for(int i = 0; i < int.Parse(s[0]); i++)
        {
            char[] c = Console.ReadLine().ToCharArray();
            for(int j = c.Length-1; j >= 0 ; j--)
            {
                Console.Write(c[j]);
            }
            Console.WriteLine();
        }
        
    }
}