using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 2; i++)
        {
            int sum = 0;
            string[] s = Console.ReadLine().Split();
            sum += int.Parse(s[0]) * 6;
            sum += int.Parse(s[1]) * 3;
            sum += int.Parse(s[2]) * 2;
            sum += int.Parse(s[3]) * 1;
            sum += int.Parse(s[4]) * 2;
            Console.Write(sum + " ");
        }
    }
}