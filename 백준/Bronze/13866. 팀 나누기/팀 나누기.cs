using System;

class Program
{
    static void Main()
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        string[] s = Console.ReadLine().Split();
        int sum = 0;
        for(int i = 0; i < s.Length; i++)
        {
            int a = int.Parse(s[i]);
            sum += a;
            if (a < min) min = a;
            if (a > max) max = a;
            
        }
        sum -= 2 * (min + max);

        if (sum < 0) sum *= -1;
        Console.WriteLine(sum);
    }
}