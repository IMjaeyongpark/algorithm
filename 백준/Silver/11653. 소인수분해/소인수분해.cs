using System;
using System.Text;

class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int N = int.Parse(Console.ReadLine());
            while (N != 1)
            {
                for(int i = 2; i <= N; i++)
                {
                    if (N % i == 0)
                    {
                        N /= i;
                        sb.Append(i + "\n");
                        break;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }