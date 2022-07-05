using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        if (N != 0)
        {
            string[] s = Console.ReadLine().Split();
            for(int i = 0; i < N; i++)
            {
                sum += int.Parse(s[i]);
            }
        }
        if (sum == 0)
        {
            Console.WriteLine("divide by zero");

        }
        else Console.WriteLine("1.00");
    }
}