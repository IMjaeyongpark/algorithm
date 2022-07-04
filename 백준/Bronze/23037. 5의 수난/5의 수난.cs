using System;

class Program
{
    static void Main()
    {
        char[] c = Console.ReadLine().ToCharArray();
        int sum = 0;
        for(int i = 0; i < c.Length; i++)
        {
            int a = c[i] - '0';
            sum += a * a * a * a * a;
        }
        Console.WriteLine(sum);
    }
}