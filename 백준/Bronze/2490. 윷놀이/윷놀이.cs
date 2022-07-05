using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            string[] s = Console.ReadLine().Split();
            int a = 0;
            for(int j = 0; j < s.Length; j++)
            {
                if (int.Parse(s[j]) == 0)
                {
                    a++;
                }
            }
            char c = 'A';
            if (a == 0) c = 'E';
            else
            {
                c += (char)(a - 1);
            }
            Console.WriteLine(c);
        }
    }
}