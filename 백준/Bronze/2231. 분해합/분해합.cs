using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int a = num - 9 * num.ToString().Length;
        int b = 0;
        for(int i = a; i < num; i++)
        {
            int c = i;
            int sum = i;
            while (c > 0)
            {
                sum += c % 10;
                c /= 10;
            }
            if (sum == num)
            {
                b = i;
                break;
            }
        }
        Console.WriteLine(b);
    }
}