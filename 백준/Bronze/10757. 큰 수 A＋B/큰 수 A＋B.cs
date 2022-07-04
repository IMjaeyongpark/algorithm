using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] s = Console.ReadLine().Split();
        char[] num1 = s[0].ToCharArray();
        char[] num2 = s[1].ToCharArray();
        int N = num1.Length >= num2.Length ? num1.Length : num2.Length;
        bool check = num1.Length >= num2.Length ? true : false;
        int[] sum = new int[N + 1];
        int i = 1;

        for ( i = 1; i <= N && num1.Length - i >= 0 && num2.Length - i >= 0; i++)
        {
            sum[sum.Length - i] += num1[num1.Length - i] + num2[num2.Length - i] - '0' - '0';
            if (sum[sum.Length - i] >= 10)
            {
                sum[sum.Length - i] -= 10;
                sum[sum.Length - i - 1]++;
            }
        }
        if (check == true)
        {
            for (i = i; i <= N ; i++)
            {
                sum[sum.Length -i] += num1[num1.Length - i] - '0';
                if (sum[sum.Length-i] >= 10)
                {
                    sum[sum.Length - i] -= 10;
                    sum[sum.Length - i - 1]++;
                }
            }
        }
        else
        {
            for (i = i; i <= N ; i++)
            {
                sum[sum.Length - i] += num2[num2.Length - i] - '0';
                if (sum[sum.Length - i] >= 10)
                {
                    sum[sum.Length - i] -= 10;
                    sum[sum.Length - i - 1]++;
                }
            }
        }
        if (sum[0]>0)sb.Append(sum[0]);
        for (i = 1; i < sum.Length; i++)
        {
            sb.Append(sum[i]);
        }
        Console.WriteLine(sb.ToString());
    }
}