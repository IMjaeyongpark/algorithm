using System;
using System.Text;

class Program
{
    
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] s = Console.ReadLine().Split();
        int M = int.Parse(s[0]);
        int N = int.Parse(s[1]);
        if (M == 2 || M == 1)
        {
            sb.Append(2 + "\n");
            M = 3;
        }
        if (M % 2 == 0) M ++;
        for(int i = M; i <= N; i+=2)
        {
            if (i == 2 || i == 3 || i == 5 || i == 7 || i == 11) sb.Append(i + "\n");
            else
            {
                if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0)
                {

                    int check = 0;
                    for (int j = 13; j < i / 11; j += 2)
                    {
                        if (i % j == 0)
                        {
                            check = 1;
                            break;
                        }
                    }
                    if (check == 0) sb.Append(i + "\n");
                }
            }
        }
        Console.WriteLine(sb);
    }
}