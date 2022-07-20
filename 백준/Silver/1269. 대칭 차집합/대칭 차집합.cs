using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        string[] s1 = Console.ReadLine().Split();
        int[] a = Array.ConvertAll(s1, int.Parse);
        string[] s2 = Console.ReadLine().Split();
        int[] b = Array.ConvertAll(s2, int.Parse);
        var list = new List<int>();
        list.AddRange(a);
        list.AddRange(b);
        int[] c = list.ToArray();
        int count = 0;
        Array.Sort(c);
        for(int i = 0; i < c.Length - 1; i++)
        {
            if (c[i] != c[i + 1])
            {
                count++;
            }
            else i++;
        }
        if (c[c.Length - 1] != c[c.Length - 2]) count++;
        Console.WriteLine(count);
    }
}