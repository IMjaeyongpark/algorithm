using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        List<char> c = Console.ReadLine().ToList<char>();
        c.Add('1');
        c.Add('1');
        if (c[0] != '1')
        {
            sum = c[0] + c[1] - '0' - '0';
            if (c[1] == '1' && c[2] == '0') sum += 9;

        }
        else
        {
            if (c[0] == '1' && c[1] == '0') sum = 10 + c[2] - '0';
            else sum = c[0] + c[1] - '0' - '0';
            if ((c[1] == '1' && c[2] == '0') || (c[2] == '1' && c[3] == '0')) sum += 9;
        }
        Console.WriteLine(sum);
    }
}