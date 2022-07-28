using System;

class Program
{
    static void Main()
    {
        char[] pipe = Console.ReadLine().ToCharArray();
        int count = 0;
        int cnt = 0;
        bool check = false;
        foreach(var c in pipe)
        {
            if(c == '(')
            {
                cnt++;
                check = true;
            }
            else
            {
                if (check)
                {
                    count += cnt - 1;
                    check = false;
                }
                else count++;
                cnt--;
            }
        }
        Console.WriteLine(count);
    }
}