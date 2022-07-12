using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int[] sosu = new int[246930];
        while (true)
        {
            int count = 0;
            int n = int.Parse(Console.ReadLine());
            if (n == 0) break;
            n++;
            if (n == 2) count++;
            for(int i = n; i <= 2 * (n-1); i+=2)
            {
                if (i % 2 == 0) i--;
                else if (i == 3 || i == 5 || i == 7 || i == 11)
                {
                    sosu[i] = 2;
                    count++;
                }
                else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0)
                {
                    if (sosu[i] == 0)
                    {
                        int check = 0;
                        for (int k = 13; k < i / 11; k += 2)
                        {
                            if (i % k == 0)
                            {
                                sosu[i] = 1;
                                check = 1;
                                break;
                            }
                        }
                        if (check == 0) sosu[i] = 2;
                    }
                    if (sosu[i] == 2) count++;
                }
            }
            sb.Append(count + "\n");
        }
        Console.WriteLine(sb);
    }
}