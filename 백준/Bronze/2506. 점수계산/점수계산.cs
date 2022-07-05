using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();
        int count = 0;
        int score = 0;
        for(int i = 0; i < N; i++)
        {
            if (int.Parse(s[i]) == 1)
            {
                score += ++count;
            }
            else count = 0;
        }
        Console.WriteLine(score);
    }
}