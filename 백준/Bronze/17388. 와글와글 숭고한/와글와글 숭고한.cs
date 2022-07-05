using System;

class Program
{
    static void Main()
    {

        string[] s = Console.ReadLine().Split();
        int S = int.Parse(s[0]);
        int K = int.Parse(s[1]);
        int H = int.Parse(s[2]);
        string s1 = "";
        int min = int.MaxValue;
        int check = 0;

        if (S + K + H >= 100) s1 = "OK";
        else
        {
              for(int i = 0; i < 3; i++)
            {
                if (min > int.Parse(s[i]))
                {
                    min = int.Parse(s[i]);
                    check = i;
                }
            }
            switch (check)
            {
                case 0:
                    s1 = "Soongsil";
                    break;
                case 1:
                    s1 = "Korea";
                    break;
                case 2:
                    s1 = "Hanyang";
                    break;
            }
        }
        
        Console.WriteLine(s1);
    }
}