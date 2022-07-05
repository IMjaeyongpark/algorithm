using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int g25 = int.Parse(s[0]);
        int m25 = int.Parse(s[1]);

        int N = int.Parse(Console.ReadLine());
        double min = (double)g25 / (double)m25;
        for(int i = 0; i < N; i++)
        {
            string[] s1 = Console.ReadLine().Split();
            int g = int.Parse(s1[0]);
            int m = int.Parse(s1[1]);
            if(min > (double)g / (double)m)
            {
                min = (double)g / (double)m;
            }
        }
        min *= 1000;
        Console.WriteLine($"{min:0.00}");
    }
}