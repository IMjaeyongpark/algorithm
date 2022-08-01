using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        Dictionary<int,int> map = new Dictionary<int,int>();
        int[] check = new int[101];
        Queue<int> loca = new Queue<int>();
        for(int i = 0; i < int.Parse(s[0]) + int.Parse(s[1]); i++)
        {
            string[] snake = Console.ReadLine().Split();
            map.Add(int.Parse(snake[0]), int.Parse(snake[1]));
        }
        loca.Enqueue(1);
        while (loca.Count > 0 && check[100] == 0)
        {
            int x = loca.Dequeue();
            for (int j = 1; x + j < 101 && j <= 6; j++)
            {
                int y = x + j;
                if (map.ContainsKey(y)) y = map[y];
                if (check[y] == 0)
                {
                    check[y] = check[x] + 1;
                    loca.Enqueue(y);
                }
            }
        }
        Console.WriteLine(check[100]);
    }
}