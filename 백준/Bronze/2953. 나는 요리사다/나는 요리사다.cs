using System;

class Program
{
    static void Main()
    {
        
        int max = int.MinValue;
        int count = 0;
        for (int i = 0; i < 5; i++)
        {
            int score = 0;
            string[] s = Console.ReadLine().Split();
            for(int j = 0; j < s.Length; j++)
            {
                score += int.Parse(s[j]);
            }
            if (score > max)
            {
                max = score;
                count = i + 1;
            }
        }
        Console.WriteLine(count + " " + max);
    }
}