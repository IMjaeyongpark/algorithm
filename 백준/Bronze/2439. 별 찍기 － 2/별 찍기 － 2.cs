using System;
using System.Text;

class Program{
    static void Main(){
        int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                for(int j = N; j > 0; j--)
                {
                    if (j > i) sb.Append(" ");
                    else sb.Append("*");
                }
                sb.Append("\n");
            }
            Console.Write(sb);
    }
}