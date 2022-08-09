using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] save = { 0 };
        for (int i = 0; i < N; i++)
        {
            int[] num;
            num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < num.Length; j++)
            {
                if (j == 0) num[0] += save[0];
                else if (j == num.Length - 1) num[j] += save[j - 1];
                else
                {
                    num[j] += save[j] >= save[j - 1] ? save[j] : save[j - 1];
                }
            }
            save = num;
        }
        int max = int.MinValue;
        for (int i = 0; i < save.Length; i++)
        {
            if (max < save[i]) max = save[i];
        }
        Console.WriteLine(max);
    }
}