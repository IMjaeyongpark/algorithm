using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] t1 = Console.ReadLine().Split(":");
        string[] t2 = Console.ReadLine().Split(":");
        int h1 = int.Parse(t1[0]);
        int m1 = int.Parse(t1[1]);
        int s1 = int.Parse(t1[2]);
        int h2 = int.Parse(t2[0]);
        int m2 = int.Parse(t2[1]);
        int s2 = int.Parse(t2[2]);
        if (h1 >= h2) h2 += 24;
        s2 -= s1;
        if (s2 < 0)
        {
            s2 += 60;
            m2--;
        }
        m2 -= m1;
        if (m2 < 0)
        {
            m2 += 60;
            h2--;
        }
        h2 -= h1;
        if (h2 >= 24) h2 -= 24;
        if (h2 == 0 && m2 == 0 && s2 == 0)
        {
            h2 = 24;
        }
        Console.WriteLine($"{h2:D2}:{m2:D2}:{s2:D2}");
    }
}