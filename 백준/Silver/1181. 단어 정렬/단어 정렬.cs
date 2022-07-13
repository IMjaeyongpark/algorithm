using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        List<string> list = new List<string>();
        for(int i = 0; i < N; i++)
        {
           list.Add(Console.ReadLine());
        }
        list = list.Distinct().ToList();
        list.Sort();
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i; j >= 0 && list[j].Length > list[j + 1].Length; j--)
            {
                string temp = list[j];
                list[j] = list[j + 1];
                list[j + 1] = temp;
            }
        }
        foreach(string s in list)
        {
            sb.Append(s + "\n");
        }
        Console.WriteLine(sb);
    }
}
