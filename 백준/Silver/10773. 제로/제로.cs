using System;

class Program
{

    static void Main()
    {
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            List<int> list = new List<int>();
            for(int i = 0; i < N; i++)
            {
                int M = int.Parse(Console.ReadLine());
            if (M == 0 && list.Count > 0)
            {
                sum -= list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }
            else
            {
                list.Add(M);
                sum += M;
            }
            }
        Console.WriteLine(sum);
    }
}