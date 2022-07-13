using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        int[,] a = new int[N, 3]; 
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            a[i, 0] = int.Parse(s[0]);
            a[i, 1] = int.Parse(s[1]);
        }
        for(int j = 0; j < N; j++)
        {
            for(int k = 0; k < N; k++)
            {
                if (j != k)
                {
                    if (a[j, 0] < a[k, 0]&& a[j, 1] < a[k, 1])
                    {
                        a[j, 2]++;
                    }
                    
                }
            }
        }
        
        for (int k = 0; k < N; k++)
        {
            sb.Append((a[k, 2]+1) + " ");
        }
        Console.WriteLine(sb);
    }
}