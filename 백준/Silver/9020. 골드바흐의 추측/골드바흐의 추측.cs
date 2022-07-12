using System;
using System.Text;

class Program
{
    static int check(int a)
    {
        if (a == 3 || a == 5 || a == 7 || a == 11) return 2;
        else if (a % 2 != 0 && a % 3 != 0 && a % 5 != 0 && a % 7 != 0 && a % 11 != 0)
        {
            for (int j = 13; j < a / 11; j += 2)
            {
                if (a % j == 0)
                {
                    return 1;
                }
            }
            return 2;
        }
        return 1;
    }
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] sosu = new int[10001];
        sosu[2] = 2;
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());

            if (m == 4) sb.Append(2 + " " + 2 + "\n");
            else
            {
                int a, b;
                a = b = m / 2;
                if (a % 2 == 0)
                {
                    a--;
                    b++;
                }
                a += 2;
                b -= 2;
                do
                {
                    a -= 2;
                    b += 2;
                    if (sosu[a] == 0)
                    {
                        sosu[a] = check(a);
                    }
                    if (sosu[b] == 0)
                    {
                        sosu[b] = check(b);
                    }
                } while (sosu[a] != 2 || sosu[b] != 2);
                sb.Append(a + " " + b + "\n");
            }
        }
        Console.WriteLine(sb);
    }
}