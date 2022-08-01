using System;

class Program
{
    static List<int> B;
    static int search(int start,int end, int key)
    {
        int mid = (start + end) / 2;
        if (end >=start)
        {
            if (B[mid] == key) return mid;
            else if (B[mid] > key) return search(start, mid - 1, key);
            else return search(mid + 1, end, key);
        }
        return start - 1;
    }
    static void Main()
    {
        int count = 0;
        int N = int.Parse(Console.ReadLine());
        int[] C = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int M = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        B = a.ToList<int>();
        B.Sort();
        Array.Sort(C);
        if (C[C.Length - 1] < B[B.Count - 1]) count = -1;
        else
        {
            while (B.Count > 0)
            {
                for (int i = 0; i < C.Length; i++)
                {
                    int idx = search(0, B.Count - 1, C[i]);
                    if (idx != -1)
                    {
                        B.RemoveAt(idx);
                    }
                }
                count++;
            }
        }
        Console.Write(count);
    }
}