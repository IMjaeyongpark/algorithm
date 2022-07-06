using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int sum = 1;
        for(int i = 0; i < N; i++)
        {
            if(i==0) sum++;
            else
            {
                sum += (i+1) / 2 + 1;
            }
        }
        Console.WriteLine(sum);
    }
}