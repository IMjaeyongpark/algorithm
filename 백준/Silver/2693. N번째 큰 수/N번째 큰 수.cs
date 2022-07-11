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
            int M1 = 0;
            int M2 = 0;
            int M3 = 0;
            string[] s = Console.ReadLine().Split();
            for(int j = 0; j < 10; j++)
            {
                int a = int.Parse(s[j]);
                if (M1 <= a)
                {
                    M3 = M2;
                    M2 = M1;
                    M1 = a;
                }
                else if (M2 <= a)
                {
                    M3 = M2;
                    M2 = a;
                }
                else if (M3 <= a) M3 = a;
            }
            sb.Append(M3 + "\n");
        }
        Console.WriteLine(sb);
    }
}