using System;
using System.Text;

class Program
    {
        static void Main(string[] agrs)
        {
            int K = int.Parse(Console.ReadLine());
            for (int i = 0; i < K; i++)
            {
                string[] s = Console.ReadLine().Split();
                int H = int.Parse(s[0]);
                int W = int.Parse(s[1]);
                int N = int.Parse(s[2]);
                int Y = N % H;
                if (Y == 0) Y = H;
                int X = N / H + 1;
                if (N % H == 0) X--;
                Console.WriteLine(Y + "" + $"{X:D2}");
            }
        }
    }