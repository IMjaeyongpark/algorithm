using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        string s1 = "mixed";
        for(int i = 0; i < s.Length-1; i++)
        {
            s1 = "ascending";
            if (int.Parse(s[i]) != i + 1)
            {
                s1 = "mixed";
                break;
            }
        }
        if (s1 == "mixed")
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                s1 = "descending";
                if (int.Parse(s[i]) != 8 - i)
                {
                    s1 = "mixed";
                    break;
                }
            }
        }
        Console.WriteLine(s1);
    }
}
