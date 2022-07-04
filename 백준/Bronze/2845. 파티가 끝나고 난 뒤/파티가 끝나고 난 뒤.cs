using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int a = int.Parse(s[0]) * int.Parse(s[1]);

        string[] s1 = Console.ReadLine().Split();
        int[] b = { int.Parse(s1[0]) - a, int.Parse(s1[1]) - a, int.Parse(s1[2]) - a, int.Parse(s1[3]) - a, int.Parse(s1[4]) - a };
        for(int i = 0; i < b.Length; i++)
        {
            Console.Write(b[i] + " ");
        }
 
    }
}