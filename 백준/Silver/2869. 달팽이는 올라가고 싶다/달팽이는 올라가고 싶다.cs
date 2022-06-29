using System;

class Program
    {

        static void Main(string[] agrs)
        {
            string[] s = Console.ReadLine().Split();
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            int V = int.Parse(s[2]);
            int day = 0;
            int count = 0;
            day = V / (A - B);
            while ((V - (day - count-1) * (A - B)) <= A)
            {
                count++;
            }
                
            Console.WriteLine(day-count+1);
        }
    }