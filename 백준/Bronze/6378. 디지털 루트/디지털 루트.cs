using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            int D = 0;
            char[] N = Console.ReadLine().ToCharArray();
            if (N[0] == '0') break;
            for(int i = 0; i < N.Length; i++)
            {
                D += N[i] - '0';
            }
            int a = 0;
            while (D >= 10)
            {
                a = 0;
                while (D > 0)
                {
                    a += D % 10;
                    D /= 10;
                }
                D = a;
            }
            sb.Append(D + "\n");
            
        }
        Console.WriteLine(sb);
    }
}