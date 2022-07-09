using System;
using System.Text;

class Program
{

    static int count = 0;
    static bool Check(int i,int j)
    {
        int a = 1;
        for(int k =0; k < count; k++)
        {
            if ((i / a) % 3 == 1 && (j / a) % 3 == 1) return true;
            a *= 3;
        }
        return false;
    }
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        int c = N;
        for (count = 0; c != 1; count++) c /= 3;
        
            for (int i = 0; i < N / 3; i++)
            {
                for (int j = 0; j < N / 3; j++)
                {
                if (Check(i,j)) sb.Append("   ");
                else sb.Append("***");
                }
                sb.Append("\n");
                for (int j = 0; j < N / 3; j++)
                {
                if (Check(i, j)) sb.Append("   ");
                else sb.Append("* *");
            }
                sb.Append("\n");
                for (int j = 0; j < N / 3; j++)
                {
                if (Check(i, j)) sb.Append("   ");
                else sb.Append("***");
            }
                sb.Append("\n");
            }
        
        Console.WriteLine(sb);
    }
}