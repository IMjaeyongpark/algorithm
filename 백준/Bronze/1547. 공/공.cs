using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] a = { 1, 0, 0 };
        for(int i= 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            int temp = a[int.Parse(s[0]) - 1];
            a[int.Parse(s[0]) - 1] = a[int.Parse(s[1]) - 1];
            a[int.Parse(s[1]) - 1] = temp;
        }
        for (int i = 0; i < 3; i++)
        {
            if (a[i] == 1)
            {
                Console.WriteLine(i + 1);
                break;
            }
        }
    }
}