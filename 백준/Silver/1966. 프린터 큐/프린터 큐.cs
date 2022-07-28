using System;
using System.Text;

class Program
{
    struct qidx
    {
        public int num;
        public int idx;
    }
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int T = int.Parse(Console.ReadLine());
        for(int i = 0; i < T; i++)
        {
            Queue<qidx> q = new Queue<qidx>();
            Queue<int> num = new Queue<int>();
            string[] s = Console.ReadLine().Split();
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for(int j = 0; j < N; j++)
            {
                qidx b = new qidx();
                b.idx = j; 
                b.num = a[j];
                q.Enqueue(b);
            }
            Array.Sort(a);
            for (int j = N - 1; j >= 0; j--) num.Enqueue(a[j]);
            int count = 0;
            int search = num.Dequeue();
            while (true)
            {
                qidx tmp = q.Dequeue();
                if (search == tmp.num)
                {
                    count++;
                    if (M == tmp.idx) break;
                    search = num.Dequeue();
                }
                else q.Enqueue(tmp);
            }
            sb.Append(count + "\n");
        }
        Console.WriteLine(sb);
    }
}