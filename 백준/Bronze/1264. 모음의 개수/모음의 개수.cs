using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int count = 0;
            char[] c = Console.ReadLine().ToCharArray();
            if (c[0] == '#') break;
            for(int i = 0; i < c.Length; i++)
            {
                if(c[i] == 'a'|| c[i] == 'e'|| c[i] == 'i'|| c[i] == 'o'|| c[i] == 'u'|| c[i] == 'A' || c[i] == 'E' || c[i] == 'I' || c[i] == 'O' || c[i] == 'U')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}