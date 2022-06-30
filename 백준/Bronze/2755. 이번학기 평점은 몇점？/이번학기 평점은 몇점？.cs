using System;
using System.Text;

class Program
{
   
    static void Main()
    {
        double sum = 0.0;
        int hak = 0;
        int N = int.Parse(Console.ReadLine());

        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            char[] c = new char[2];
            hak += int.Parse(s[1]);
            c = s[2].ToCharArray();
            if (c[0] == 'A')
            {
                sum += 4.0 * double.Parse(s[1]);
                
            }
            else if (c[0] == 'B')
            {
                sum += 3.0 * double.Parse(s[1]);


            }
            else if (c[0] == 'C')
            {
                sum += 2.0 * double.Parse(s[1]);
                
            }
            else if (c[0] == 'D')
            {
                sum += 1.0 * double.Parse(s[1]);
                
            }
            if (c[0] != 'F')
            {
                if (c[1] == '+') sum += 0.3 * double.Parse(s[1]);
                else if (c[1] == '-') sum -= 0.3 * double.Parse(s[1]);
            }
        }
        sum = sum/(double)hak;
        Console.WriteLine("{0:0.00}",sum);
    }
}
