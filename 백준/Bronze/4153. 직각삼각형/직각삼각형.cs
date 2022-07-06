using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            bool check=false;
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            if (a == 0 && b == 0 && c == 0) break;

            if(a > b && a > c)
            {
                check = a * a == b * b + c * c ? true : false;
            }
            else if(b>a&& b > c)
            {
                check = b * b == a * a + c * c ? true : false;
            }
            else if(c>a&& c > b)
            {
                check = c * c == a * a + b * b ? true : false;
            }
            if (check == false)
            {
                Console.WriteLine("wrong");
            }
            else Console.WriteLine("right");
        }
    }
}