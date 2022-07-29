using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Dictionary<string, int> map = new Dictionary<string, int>();    
        for(int i = 0; i < N; i++)
        {
            string s = Console.ReadLine();
            if (map.ContainsKey(s)) map[s]++;
            else map.Add(s, 1);
        }
        for(int i=0; i < N-1; i++)
        {
            string s = Console.ReadLine();
            map[s]--;
            if (map[s] == 0) map.Remove(s);
        }
        Console.WriteLine(map.First().Key);
    }
}