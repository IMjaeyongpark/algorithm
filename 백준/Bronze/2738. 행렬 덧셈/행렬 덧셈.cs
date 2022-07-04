using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);

        var ar1 = new int[a, b];
        var ar2 = new int[a, b];
        for(int i = 0; i < a; i++)
        {
            string[] s1 = Console.ReadLine().Split();
            for(int j = 0; j < b; j++)
            {
                ar1[i, j] = int.Parse(s1[j]);
            }
        }
        for (int i = 0; i < a; i++)
        {
            string[] s1 = Console.ReadLine().Split();
            for (int j = 0; j < b; j++)
            {
                ar2[i, j] = int.Parse(s1[j]);
            }
        }
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                sb.Append(ar1[i, j] + ar2[i, j] + " ");
            }
            sb.Append("\n");
        }
        Console.WriteLine(sb);
    }
}