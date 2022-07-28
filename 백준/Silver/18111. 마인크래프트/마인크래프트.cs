using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int y = int.Parse(s[0]);
        int x = int.Parse(s[1]);
        int block = int.Parse(s[2]);
        int[,] grand = new int[x, y];
        int second = int.MaxValue;
        int H = 0;
        int min = int.MaxValue;
        int max = int.MinValue;
        for(int i = 0; i < y; i++)
        {
            string[] s1 = Console.ReadLine().Split();
            for(int j = 0; j < x; j++)
            {
                int a = int.Parse(s1[j]);
                if (a < min) min = a;
                if (a > max) max = a;
                grand[j, i] = a;
            }
        }


        int bcnt = 0;
        for (int k = min; true; k++)
        {
            bcnt = 0;
            int second2 = 0;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (k > grand[j, i])
                    {
                        bcnt += k - grand[j, i];
                        second2 += k - grand[j, i];
                    }
                    else if (k < grand[j, i])
                    {
                        second2 += (grand[j, i] - k) * 2;
                        bcnt -= grand[j, i] - k;
                    }
                }
            }
            if (bcnt > block || max < k) break;
            if (second >= second2)
            {
                second = second2;
                if (H < k) H = k;
            }
        }
        Console.WriteLine(second + " " + H);
    }
}