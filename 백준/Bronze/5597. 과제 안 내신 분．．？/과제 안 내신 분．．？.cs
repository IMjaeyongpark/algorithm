using System;

class Program
{
   
    static void Main()
    {
        int[] a = new int[30];
        for(int i = 0; i < 28; i++)
        {
            a[int.Parse(Console.ReadLine()) - 1]++;
        }
        for(int i = 0; i < 30; i++)
        {
            if (a[i] == 0) Console.WriteLine(i+1);
        }
    }
}
