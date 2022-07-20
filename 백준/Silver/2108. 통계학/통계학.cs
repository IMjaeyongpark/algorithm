using System;
using System.Text;


class Program
{
    static void Main()
    {
        int[] n = new int[8001];
        int N = int.Parse(Console.ReadLine());
        int[] num = new int[N];
        int sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < N; i++)
        {
            int a = int.Parse(Console.ReadLine());
            sum += a;
            num[i] = a;
            if (max < a) max = a;
            if (min > a) min = a;
            n[a + 4000]++;
        }
        Array.Sort(num);
        double sum1 = (double)sum / N;
        if (sum1 - sum / N >= 0.5 && sum1 - sum / N > 0) sum1++;
        else if (sum1 - sum / N <= -0.5 && sum1 - sum / N < 0) sum1--;
        Console.WriteLine((int)sum1);
        Console.WriteLine(num[N / 2]);
        int many = int.MinValue;
        int save = 0;
        int check = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] >= many)
            {
                if (n[i] == many)
                {
                    if (check == 0)
                    {
                        save = i;
                        many = n[i];
                        check = 1;
                    }
                }
                else
                {
                    save = i;
                    many = n[i];
                    check = 0;
                }
            }
        }
        Console.WriteLine(save - 4000);
        Console.WriteLine(max - min);
    }
}