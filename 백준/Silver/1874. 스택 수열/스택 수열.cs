using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        int[] a = new int[N];
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < N; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int c = 0;
        for(int i = 0; i < N; i++)
        {
            stack.Push(i + 1);
            sb.Append("+\n");
            while (c < N && stack.Count > 0 && stack.First() == a[c])
            {
                stack.Pop();
                sb.Append("-\n");
                c++;
            }
        }
        if (c == N) Console.WriteLine(sb);
        else Console.WriteLine("NO");
    }
}