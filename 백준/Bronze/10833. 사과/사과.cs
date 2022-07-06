using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            sum += b % a;
        }
        Console.WriteLine(sum);
        
    }
}