using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int n = int.Parse(s[0]);
        int T = int.Parse(s[1]);
        int sum = 0;
        int count = 0;
        
        string[] s1 = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            if (sum + int.Parse(s1[i]) > T) break;
            sum += int.Parse(s1[i]);
            count++;
        }
        
        Console.WriteLine(count);
    }
}