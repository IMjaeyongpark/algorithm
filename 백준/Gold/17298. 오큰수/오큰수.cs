using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int[] O = new int[N];
        Stack<int> idx = new Stack<int>();
        int num = 0;
        for(int i= 0; i < N; i++)
        {
            if (num < a[i])
            {
                while(idx.Count > 0)
                {
                    int index = idx.Pop();
                    if (a[i] > a[index]) O[index] = a[i];
                    else
                    {
                        idx.Push(index);
                        break;
                    }
                }
            }
            idx.Push(i);
            num = a[i];
        }
        foreach(var item in O)
        {
            if (item == 0) sb.Append(-1 + " ");
            else sb.Append(item + " ");
        }
        Console.WriteLine(sb);
    }
}