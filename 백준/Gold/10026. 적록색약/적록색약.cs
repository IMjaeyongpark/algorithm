using System;
using System.Text;

class Program
{
    static int count1 = 0;
    static int count2 = 0;
    static char[,] RGB;
    static int N;
    static void no(int x, int y, char c)
    {
        if (c != 'B') RGB[x, y] = '1';
        else RGB[x, y] = '2';
        if (x - 1 >= 0 && RGB[x - 1, y] == c) no(x - 1, y, c);
        if (y - 1 >= 0 && RGB[x, y - 1] == c) no(x, y - 1, c);
        if (x + 1 < N && RGB[x + 1, y] == c) no(x + 1, y, c);
        if (y + 1 < N && RGB[x, y + 1] == c) no(x, y + 1, c);
    }
    static void yes(int x, int y, char c)
    {
        RGB[x, y] = '0';
        if (x - 1 >= 0 && RGB[x - 1, y] == c) yes(x - 1, y, c);
        if (y - 1 >= 0 && RGB[x, y - 1] == c) yes(x, y - 1, c);
        if (x + 1 < N && RGB[x + 1, y] == c) yes(x + 1, y, c);
        if (y + 1 < N && RGB[x, y + 1] == c) yes(x, y + 1, c);
    }


    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        RGB = new char[N, N];
        for (int y = 0; y < N; y++)
        {
            char[] s = Console.ReadLine().ToCharArray();
            for (int x = 0; x < N; x++)
            {
                RGB[x, y] = s[x];
            }
        }
        for (int y = 0; y < N; y++)
        {
            for (int x = 0; x < N; x++)
            {
                char c = RGB[x, y];
                if (c == 'R' || c == 'G' || c == 'B')
                {
                    no(x, y, c);
                    count1++;
                }
            }
        }
        for (int y = 0; y < N; y++)
        {
            for (int x = 0; x < N; x++)
            {
                char c = RGB[x, y];
                if (c == '1' || c == '2')
                {
                    yes(x, y, c);
                    count2++;
                }
            }
        }
        Console.Write(count1 + " " + count2);
    }
}