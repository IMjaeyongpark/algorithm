using System;
using System.Text;

class Program
{
   
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int count = 0;
        string[] s = Console.ReadLine().Split();
        int N = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        string[] name = new string[N + M];
        for (int i = 0; i < N + M; i++)
        {
            name[i] = Console.ReadLine();
        }
        Array.Sort(name);
        string save = "";
        for(int i = 0; i < name.Length; i++)
        {
            if (save == name[i])
            {
                sb.Append(save + "\n");
                count++;
            }
            save = name[i];
        }
        Console.WriteLine(count + "\n" + sb);
    }
}