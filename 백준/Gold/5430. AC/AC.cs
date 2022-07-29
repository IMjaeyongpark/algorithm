using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int T = int.Parse(Console.ReadLine());
        for(int i = 0; i < T; i++)
        {
            bool error = false;
            int check = 0;
            List<int> list = new List<int>();
            char[] RD = Console.ReadLine().ToCharArray();
            int N = int.Parse(Console.ReadLine());
            string[] num = Console.ReadLine().Split('[', ']', ',');
            for(int j = 1; j <= N; j++)
            {
                list.Add(int.Parse(num[j]));
            }
            for(int j = 0; j <RD.Length; j++)
            {
                if (RD[j] == 'R')
                {
                    check++;
                }
                else if (RD[j] == 'D')
                {
                    if (list.Count > 0)
                    {
                        if (check % 2 == 0) list.RemoveAt(0);
                        else list.RemoveAt(list.Count - 1);
                    }
                    else
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (error) sb.Append("error\n");
            else
            {
                sb.Append("[");
                if (check % 2 == 0)
                {
                    for(int j = 0; j < list.Count; j++)
                    {
                        sb.Append(list[j]);
                        if (j < list.Count - 1) sb.Append(",");
                    }
                }
                else
                {
                    for (int j = list.Count - 1; j >= 0; j--)
                    {
                        sb.Append(list[j]);
                        if (j > 0) sb.Append(",");
                    }
                }
                sb.Append("]\n");
            }
        }
        Console.WriteLine(sb);
    }
}