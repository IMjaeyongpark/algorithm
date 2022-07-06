using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            int power = 0;
            string[] s = Console.ReadLine().Split();
            for (int j = 0; j < 4; j++)
            {
                int a = int.Parse(s[j]) + int.Parse(s[j + 4]);
                if (a > 0 || j == 3)
                {
                    switch (j % 4)
                    {
                        case 0: power += a; break;
                        case 1: power += a * 5; break;
                        case 2: power += a * 2; break;
                        case 3: power += a * 2; break;
                    }
                }
                else if (j == 0)
                {
                    power++;
                }
                else if (j == 1) power += 5;

            }
            sb.Append(power + "\n");
        }
        Console.WriteLine(sb);
    }
}