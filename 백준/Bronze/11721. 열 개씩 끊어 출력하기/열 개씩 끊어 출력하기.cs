using System;

class Program
{
    static void Main()
    {
        char[] c = Console.ReadLine().ToCharArray();
        for(int i = 0; i <c.Length;i++)
        {
            Console.Write(c[i]);
            if ((i + 1) % 10 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}