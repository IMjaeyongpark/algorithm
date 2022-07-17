using System;

class Program
{
   
    static void Main()
    {
        char[] c = Console.ReadLine().ToCharArray();
        int sum = 0;
        int a = 0;
        int check = 0;
        for(int i = 0; i < c.Length; i++)
        {
            if (c[i] == '-')
            {
                if (check == 0)
                {
                    sum = a;
                    a = 0;
                }
                else if (check == 1)
                {
                    sum += a;
                    a = 0;
                }
                check = 2;
                for (i = i; i < c.Length; i++)
                {
                    if (c[i] == '-' || c[i] == '+')
                    {
                        sum -= a;
                        a = 0;
                    }
                    else
                    {
                        a *= 10;
                        a += c[i] - '0';
                    }
                }
            }
            else if (c[i] == '+')
            {
                if (check == 0)
                {
                    sum = a;
                    a = 0;
                }
                sum += a;
                a = 0;
                check = 1;
            }
            else
            {
                a *= 10;
                a += c[i] - '0';
            }
        }
        if (check == 0) sum = a;
        else if (check == 1) sum += a;
        else if (check == 2) sum -= a;
        Console.WriteLine(sum);
    }
}