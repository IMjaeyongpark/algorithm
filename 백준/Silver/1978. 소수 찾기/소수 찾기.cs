using System;

class Program{
    static void Main(){
        int N = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int count = 0;
            foreach(string s2 in s)
            {
                int a = int.Parse(s2);
                if (a <= 2)
                {
                    if (a == 2) count++;
                }
                else
                {
                    for (int i = 2; i < a ; i++)
                    {
                        if (a % i == 0) break;
                        else if (i + 1 > a / 2)
                        {
                            count++;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(count);
    }
}