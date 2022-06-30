using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] score = new int[8];
        int sum = 0;
        int min = int.MaxValue;
        int[] save = new int[3];
        for(int i = 0; i < 8; i++)
        {
            score[i] = int.Parse(Console.ReadLine());
            sum += score[i];
            if (min > score[i])
            {
                min = score[i];
                save[0] = i;
            }
        }
        sum -= score[save[0]];
        score[save[0]] = int.MaxValue;
        for (int i = 0; i < 2; i++)
        {
            min = int.MaxValue;
            for (int j = 0; j < 8; j++)
            {
                if (min > score[j])
                {
                    min = score[j];
                    save[i + 1] = j;
                }

            }
            sum -= min;
            score[save[i + 1]] = int.MaxValue;
        }
        sb.Append(sum + "\n");
        for(int i=0;i<8; i++)
        {
            if (i != save[0] && i != save[1] && i != save[2])
            {
                sb.Append((i+1) + " ");
            }
        }
        Console.WriteLine(sb.ToString());
    }
}