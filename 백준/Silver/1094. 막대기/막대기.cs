using System;

class Program
    {
        static void Main(string[] agrs)
        {
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            while (N != 0)
            {
                if (N % 2 != 0)
                {
                    count++;
                    N -= 1;
                }
                N /= 2;
            }
            Console.WriteLine(count);
        }
        
    }