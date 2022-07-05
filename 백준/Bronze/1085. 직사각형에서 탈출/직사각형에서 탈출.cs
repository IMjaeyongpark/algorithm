using System;

class Program
{
    static int check(int a,int min){
        if (a < min) min = a;
        return min;
        }

    static void Main()
    {
        int min = int.MaxValue;
        string[] s = Console.ReadLine().Split();
        int x = int.Parse(s[0]);
        min = check(x, min);
        int y = int.Parse(s[1]);
        min = check(y, min);
        int w = int.Parse(s[2]);
        int h = int.Parse(s[3]);

        int x1 = x - w;
        if (x1 < 0) x1 *= -1;
        min = check(x1, min);
        int y1 = y - h;
        if(y1 < 0) y1 *= -1;
        min = check(y1, min);
        Console.WriteLine(min);
    }
}