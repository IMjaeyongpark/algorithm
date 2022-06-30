using System;
using System.Text;

class Program
{

    static void Main()
    {
        int pre = 0;
        int cur = 1;
        int temp = 0;
        int N = int.Parse(Console.ReadLine());
        for(int i = 1; i < N; i++)
        {
            temp = pre;
            pre = cur;
            cur += temp;
        }
        if (N == 0) cur = 0;
        Console.WriteLine(cur);
    }
}