using System;

class Program
    {
        static void Main(string[] agrs)
        {
            char[] c = Console.ReadLine().ToCharArray();

                int[] check = new int[2];
                int[] count = new int[2];
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] == '0')
                    {
                        check[0] = 1;
                    }
                    else if (check[0] == 1 && c[i] == '1')
                    {
                        check[0] = 0;
                        count[0]++;
                    }
                    if (c[i] == '1')
                    {
                        check[1] = 1;
                    }
                    else if (check[1] == 1 && c[i] == '0')
                    {
                        check[1] = 0;
                        count[1]++;
                    }
                }
                if (check[0] == 1) count[0]++;
                if (check[1] == 1) count[1]++;
                int a = 0;
                if (check[0] > check[1]) a = 1;
                Console.WriteLine(count[a]);
        }
    }