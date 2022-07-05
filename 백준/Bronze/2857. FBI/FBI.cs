using System;
using System.Text;

class Program
{
    static void Main()
    {
        int check = 0;
        StringBuilder sb = new StringBuilder();
       for(int i = 0; i < 5; i++)
        {
            string s =Console.ReadLine();
            if (s.Contains("FBI"))
            {
                sb.Append(i + 1 + " ");
                check = 1;
            }

        }
        if (check == 0) Console.WriteLine("HE GOT AWAY!");
        else Console.WriteLine(sb);
    }
}