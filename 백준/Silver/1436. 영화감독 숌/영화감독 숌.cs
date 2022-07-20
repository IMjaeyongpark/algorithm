using System;
using System.Text;

class Program
{ 
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        List<char> list = new List<char>();
        int count = 1;
        list.Add('6');
        list.Add('6');
        list.Add('6');
        while (count < N)
        {
            int cnt = 0;
            list[0]++;
            bool check = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (i >= list.Count - 1)
                {
                    if (list[i] > '9')
                    {
                        list[i] = '0';
                        list.Add('1');
                    }
                }
                else if (list[i] > '9')
                {
                    list[i] = '0';
                    list[i + 1]++;
                }
                if (i < list.Count - 1 && list[i] == '6' && list[i + 1] == '6') cnt++;
                else if (!check) cnt = 0;
                if (cnt >= 2) check = true;
            }
            if (check) count++;
        }
        for(int i = list.Count - 1; i >= 0; i--)
        {
            sb.Append(list[i]);
        }
        Console.WriteLine(sb);
    }
}