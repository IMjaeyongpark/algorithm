using System;

class Program{
    static void Main(){
        int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                int score = 0;
                string s=Console.ReadLine();
                string[] a = s.Split();
                int k = int.Parse(a[0]);
                for (int j = 1; j < k+1; j++)
                {
                    score += int.Parse(a[j]);
                }
                int count = 0;
                double b = (double)score / (double)k;
                for(int j = 1; j < k+1; j++)
                {
                    
                    if (b < int.Parse(a[j]))count++;
                }
                Console.WriteLine("{0:0.000}%", ((double)count / (double)k * 100.0));
            }
    }
}