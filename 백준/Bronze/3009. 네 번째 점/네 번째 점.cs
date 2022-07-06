using System;

class Program
{
    static void Main()
    {
        int[] x = new int[2];
        int[] y = new int[2];
        int x1 = 0;
        int y1 = 0;
        for(int i = 0; i < 3; i++)
        {
            string[] s = Console.ReadLine().Split();
            if (i < 2)
            {
                x[i] = int.Parse(s[0]);
                y[i] = int.Parse(s[1]);
            }
            else
            {
                x1 = x[0] == int.Parse(s[0]) ? x[1] : (x[0] == x[1] ? int.Parse(s[0]) : x[0]);
                y1 = y[0] == int.Parse(s[1]) ? y[1] : (y[0] == y[1] ? int.Parse(s[1]) : y[0]);
            }
        }
        Console.WriteLine(x1 + " " + y1);
    }
}