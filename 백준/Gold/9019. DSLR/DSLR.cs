using System;
using System.Text;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < N; i++)
        {
            Queue<int> q = new Queue<int>();    
            int[] bfs = new int[10000];
            string[] DSLR = new string[10000];
            string[] s = Console.ReadLine().Split();
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            q.Enqueue(A);
            while (DSLR[B] == null)
            {
                int x = q.Dequeue();
                int dx = x * 2;
                if (dx >= 10000) dx %= 10000;
                if (DSLR[dx] == null)
                {
                    bfs[dx] = x;
                    DSLR[dx] = "D";
                    q.Enqueue(dx);
                }
                dx = x - 1;
                if (x == 0) dx = 9999;
                if (DSLR[dx] == null)
                {
                    bfs[dx] = x;
                    DSLR[dx] = "S";
                    q.Enqueue(dx);
                }
                int[] rt = new int[4];
                char[] tmp = x.ToString().ToCharArray();
                for (int j = 0; j < tmp.Length; j++) rt[4 - tmp.Length + j] = tmp[j] - '0'; 
                int temp = rt[0];
                for(int j = 1; j <rt.Length; j++)
                {
                    rt[j - 1] = rt[j];
                }
                rt[rt.Length - 1] = temp;
                string t = "";
                for (int j = 0; j < rt.Length; j++) t += rt[j];
                dx = int.Parse(t);
                if (DSLR[dx] == null)
                {
                    bfs[dx] = x;
                    DSLR[dx] = "L";
                    q.Enqueue(dx);
                }
                rt = new int[4];
                tmp = x.ToString().ToCharArray();
                for (int j = 0; j < tmp.Length; j++) rt[4 - tmp.Length + j] = tmp[j] - '0';
                temp = rt[rt.Length - 1];
                for (int j = rt.Length - 2; j >= 0; j--)
                {
                    rt[j + 1] = rt[j];
                }
                rt[0] = temp;
                t = "";
                for (int j = 0; j < rt.Length; j++) t += rt[j];
                dx = int.Parse(t);
                if (DSLR[dx] == null)
                {
                    bfs[dx] = x;
                    DSLR[dx] = "R";
                    q.Enqueue(dx);
                }
            }
            string result = "";
            int a = B;
            while (a != A)
            {
                result += DSLR[a];
                a = bfs[a];
            }
            char[] rst = result.ToCharArray();
            for(int j = rst.Length - 1; j >= 0; j--)
            {
                sb.Append(rst[j]);
            }
            sb.Append("\n");
        }
        Console.WriteLine(sb);
    }
}