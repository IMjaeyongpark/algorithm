using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        Queue<int> queue = new Queue<int>();
        string[] s = Console.ReadLine().Split();
        int k = int.Parse(s[1]);
        for(int i = 1; i <= int.Parse(s[0]); i++)
        {
            queue.Enqueue(i);
        }
        int count = 0;
        sb.Append("<");
        while(queue.Count > 0)
        {
            int i = queue.Dequeue();
            count++;
            if (count % k == 0)
            {
                sb.Append(i);
                if (queue.Count != 0) sb.Append(", ");
            }
            else queue.Enqueue(i);
        }
        sb.Append(">");
        Console.WriteLine(sb);
    }
}