using System;

class Program
{
    static void Main()
    {
        while (true) {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            if (a == 0 && b == 0) break;
            if (a > b) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        
    }
}