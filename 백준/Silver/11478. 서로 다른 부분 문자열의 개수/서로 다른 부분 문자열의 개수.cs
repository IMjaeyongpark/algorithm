using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        Dictionary<string, bool> dic = new Dictionary<string, bool>();
        int count = 0;
        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 0; j <= s.Length - i; j++)
            {
                string c = s.Substring(j, i);
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, true);
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}