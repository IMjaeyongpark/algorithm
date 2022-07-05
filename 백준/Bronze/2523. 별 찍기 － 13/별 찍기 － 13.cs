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
            for(int j = 0; j <=i; j++)
            {
                sb.Append('*');
            }
            sb.Append('\n');
        }
        for(int i = N-1; i >0; i--)
        {
            for(int j= 0; j < i; j++)
            {
                sb.Append('*');
            }
            sb.Append('\n');
        }
        Console.WriteLine(sb);
    }
}