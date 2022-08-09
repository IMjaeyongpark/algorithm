using System;
using System.Text;

class Program
{
    class Heap
    {
        public int[] h = new int[1000001];
        public int n = 0;
        public void push(int item)
        {
            int i = ++this.n;
            while((i != 1) && item > this.h[i / 2])
            {
                this.h[i] = this.h[i / 2];
                i = i / 2;
            }
            this.h[i] = item;
        }
        public void delete()
        {
            int first, temp, parent, child;
            first = this.h[1];
            temp = this.h[n--];
            parent = 1;
            child = 2;

            while(child<= n)
            {
                if ((child < this.n) && (this.h[child] < this.h[child + 1]))
                    child++;

                if (temp >= this.h[child])
                    break;

                this.h[parent] = this.h[child];
                parent = child;
                child *= 2;
            }
            this.h[parent] = temp;
        }
    }

    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        Heap heap = new Heap();
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (heap.n != 0)
                {
                    sb.Append(heap.h[1] + "\n");
                    heap.delete();
                }
                else sb.Append(0 + "\n");
            }
            else heap.push(a);
        }
        Console.WriteLine(sb);
    }
}