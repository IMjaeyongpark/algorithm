using System;

class Program
{
    static void Main()
    {
        List<char> a = Console.ReadLine().ToList<char>();
        string s = Console.ReadLine();
        List<char> b = Console.ReadLine().ToList<char>();
        int check = 0;
        if (s == "*")
        {
            for (int i = 0; i < b.Count-1; i++)
            {
                a.Add('0');
            }
        }
        else if (s == "+")
        {
            if(a.Count > b.Count)
            {
                a[a.Count - b.Count]++;
            }
            else
            {
                b[b.Count - a.Count]++;
                check = 1;
            }
        }
        if (check == 0)
        {
            foreach (char c in a)
            {
                Console.Write(c);
            }
        }
        else
        {
            foreach(char c in b)
            {
                Console.Write(c);
            }
        }
    }
}