using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] w = new int[2];
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            if (a > b) w[0]++;
            else if (a < b) w[1]++;
        }
        Console.WriteLine(w[0] + " " + w[1]);
    }
}