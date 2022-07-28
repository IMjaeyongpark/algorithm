using System;

    class Program
    {    
        static void Main()
        {
            string[] s = Console.ReadLine().Split();
            char[] c1 = s[0].ToCharArray();
            char[] c2 = s[1].ToCharArray();
            int a = 0;

            for (int i = c1.Length - 1; i >= 0; i--)
            {
                if (c1[i] > c2[i])
                {
                    a = 1;
                    break;
                }
                else if (c1[i] < c2[i])
                {
                    a = 2;
                    break;
                }

            }
            if (a == 1)
                for (int i = c1.Length - 1; i >= 0; i--)
                {
                    Console.Write(c1[i]);
                }
            if (a == 2) for (int i = c1.Length - 1; i >= 0; i--)
                {
                    Console.Write(c2[i]);
                }
        } 
    }