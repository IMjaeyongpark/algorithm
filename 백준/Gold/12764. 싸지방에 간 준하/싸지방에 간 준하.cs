using System;
using System.Text;


class Program
{
    struct Use
    {
        public int start;
        public int end;
    }
    static int search(int start, int end ,int key)
    {
        int mid = (end + start) / 2;
        if (end >= start)
        {
            if (key == list[mid].start) return mid;
            else if (key > list[mid].start) return search(mid + 1, end, key);
            else return search(start, mid - 1, key);
        }
        return start;
    }

    static List<Use> list = new List<Use>();
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        List<int> count = new List<int>();
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            list.Add(new Use());
            Use temp = list[i];
            temp.start = int.Parse(s[0]);
            temp.end = int.Parse(s[1]);
            list[i] = temp;
        }
        list = list.OrderBy(x => x.start).ToList<Use>();
        while (list.Count > 0)
        {
            int idx = 0;
            count.Add(1);
            int end = list[0].end;
            list.RemoveAt(0);
            while (idx<list.Count)
            {
                idx = search(0, list.Count - 1, end);
                if (idx < list.Count && list[idx].start >= end)
                {
                    end = list[idx].end;
                    count[count.Count - 1]++;
                    list.RemoveAt(idx);
                }
            }
            sb.Append(count[count.Count - 1] + " ");
        }
        Console.WriteLine(count.Count);
        Console.WriteLine(sb.ToString());
    }
}
