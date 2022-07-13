using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int y = int.Parse(s[0]);
        int x = int.Parse(s[1]);
        char[,] c = new char[y, x];

        for(int i = 0; i < y; i++)
        {
            char[] s2 = Console.ReadLine().ToCharArray();
            for(int j = 0; j < x; j++)
            {
                c[i, j] = s2[j];
            }  
        }
        int min = int.MaxValue;
        for(int i = 0; i + 8 <= y; i++)
        {
            for(int j = 0; j + 8 <= x; j++)
            {
                int count = 0;
                for(int k=0; k < 8; k++)
                {
                    for(int l=0; l < 8; l++)
                    {
                        if ((k + i + j + l) % 2 == 0)
                        {
                            if (c[k + i, j + l] != 'W') count++;
                        }
                        else if ((k + i + j + l) % 2 == 1)
                        {
                            if (c[k + i, j + l] != 'B') count++;
                        }
                    }
                }
                count = count >= 64 - count ? 64 - count : count;
                if(count < min) min = count;
            }
            if (min == 0) break;
        }
        Console.WriteLine(min);
    }
}