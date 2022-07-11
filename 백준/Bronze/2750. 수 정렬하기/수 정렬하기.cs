using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        for(int i = 0; i < N; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (!list.Contains(a))
            {
                list.Add(a);
            }
        }
        list.Sort();
        for(int i = 0; i < list.Count; i++)
        {
            sb.Append(list[i] + "\n");
        }
        Console.WriteLine(sb);
    }
}