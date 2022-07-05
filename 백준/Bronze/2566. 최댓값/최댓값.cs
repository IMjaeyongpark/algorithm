using System;

class Program
{
    static void Main()
    {
        int max = int.MinValue;
        int x = 0;
        int y = 0;
        for (int i = 0; i < 9; i++)
        {
            string[] s = Console.ReadLine().Split();
            for (int j = 0; j < 9; j++)
            {
                if (max < int.Parse(s[j]))
                {
                    max = int.Parse(s[j]);
                    x = j + 1;
                    y = i + 1;
                }
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(y + " " + x);
    }
}