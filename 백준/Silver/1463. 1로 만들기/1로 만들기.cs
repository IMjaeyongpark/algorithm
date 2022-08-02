using System;

class Program
{
    static void Main()
    {
        Queue<int> q = new Queue<int>();
        int[] check = new int[1000001];
        int N = int.Parse(Console.ReadLine());
        q.Enqueue(N);
        while (check[0] == 0)
        {
            int x = q.Dequeue();
            if (x % 3 == 0&&check[x / 3] == 0)
            {
                check[x / 3] = check[x] + 1;
                q.Enqueue(x / 3);
            }
            if (x % 2 == 0 && check[x/2]==0)
            {
                check[x / 2] = check[x] + 1;
                q.Enqueue(x / 2);
            }
            if (x - 1 >= 0 && check[x - 1] == 0)
            {
                check[x - 1] = check[x] + 1;
                q.Enqueue(x - 1);
            }
        }
        Console.WriteLine(check[1]);
    }
}