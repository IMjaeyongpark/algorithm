using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();
        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);
        int count = A / 2;
        count += B;

        if (count > N) count = N;
        Console.WriteLine(count);
       
    }
}