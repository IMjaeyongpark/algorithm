using System;

class Program
{
    static void Main()
    {
        char[] c = Console.ReadLine().ToCharArray();
        int[] a = new int[26];

        for(int  i= 0; i<c.Length; i++)
        {
            a[c[i] - 'a']++;
        }
        for(int i= 0; i<26; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}