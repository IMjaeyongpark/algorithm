using System;
using System.Text;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] a = new int[4];
        int AX = 0;
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);
            if (x > 0 && y > 0) a[0]++;
            else if (x < 0 && y > 0) a[1]++;
            else if (x < 0 && y < 0) a[2]++;
            else if (x > 0 && y < 0) a[3]++;
            else AX++;
        }
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Q" + (i + 1) + ": " + a[i]);
        }
        Console.WriteLine("AXIS: " + AX);
    }
}