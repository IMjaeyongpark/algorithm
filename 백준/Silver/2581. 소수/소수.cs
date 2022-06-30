using System;
using System.Text;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int min = 0;
        int sum = 0;

        for (int i = N; i <= M; i++)
        {
            int check = 0;

            if (i == 2 || i == 3 || i == 5 || i == 7||i==1)
            {
                if(i != 1){
                    sum += i;
                    if (min == 0) min = i;
                }
            }
            else if (i % 2 != 0 && i % 10 != 5)
            {
                int j = 3;
                do
                {
                    if (i % j == 0)
                    {
                        check = 1;
                        break;
                    }
                    j += 2;
                } while (j < i / 3);
                if (check == 0)
                {
                    sum += i;
                    if (min == 0) min = i;
                }
            }
        }
        if (min == 0) Console.WriteLine(-1);
        else Console.WriteLine(sum + "\n" + min);
    }
}