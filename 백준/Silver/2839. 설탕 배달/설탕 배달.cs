using System;

class Program
    {
        static void Main(string[] agrs)
        {
            int N = int.Parse(Console.ReadLine());
            int count = -1;
            if (N % 5 == 0) count = N / 5;
            else
            {
                for (int i = N % 5; i < N; i += 5)
                {
                    if (i % 3 == 0)
                    {
                        count = i / 3 + (N - i) / 5;
                        break;
                    }
                }
                if (count == -1 && N % 3 == 0) count = N / 3;
            }
            Console.WriteLine(count);
        }
    }