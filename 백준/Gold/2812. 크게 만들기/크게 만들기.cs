using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string[] a = Console.ReadLine().Split();
        int N = int.Parse(a[1]);
        char[] s = Console.ReadLine().ToCharArray();
        List<int> list = new List<int>();
        int count = 0;
        int j = 0;
        for (j = 0; count < N; j++)
        {
            int max = -1;
            int idx = 0;
            if (N + 1 - count <= s.Length - j)
            {
                for (int i = 0; i < N + 1 - count; i++)
                {
                    if (max < s[i + j] - '0')
                    {
                        idx = i + j;
                        max = s[i + j]-'0';
                        if (max == 9) break;
                    }
                }
                count += idx - j;
                j = idx;
                sb.Append(max);
            }
            else
            {
                while (count < N)
                {
                    int min = int.MaxValue;
                    for (int i = 0; i < s.Length-j; i++)
                    {
                        if (min > s[i + j] - '0' && s[i+j]!='\0')
                        {
                            idx = i + j;
                            min = s[i + j]-'0';
                            if (min == 0) break;
                        }
                    }
                    s[idx] = '\0';
                    count++;
                }
                idx = j;
            }
            
        }
        for (int i = j ; i < s.Length; i++) if (s[i] != '\0') sb.Append(s[i]);
        Console.WriteLine(sb);
    }
}