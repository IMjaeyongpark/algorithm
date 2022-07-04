using System;

class Program
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int[] num = { int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]) };
        for(int i =0; i < 2; i++)
        {
            for(int j=i; j >= 0 && num[j] > num[j+1]; j--)
            {
                int temp = num[j];
                num[j] = num[j + 1];
                num[j + 1] = temp;
            }
        }
        Console.WriteLine(num[0] + " " + num[1] + " " + num[2]);
    }
}