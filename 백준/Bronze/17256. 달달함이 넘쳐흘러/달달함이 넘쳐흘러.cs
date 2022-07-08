using System;

class Program
{
    static void Main()
    {
        string[] s1 = Console.ReadLine().Split();
        string[] s2 = Console.ReadLine().Split();
        int ax = int.Parse(s1[0]);
        int ay = int.Parse(s1[1]);
        int az = int.Parse(s1[2]);
        int cx = int.Parse(s2[0]);
        int cy = int.Parse(s2[1]);
        int cz = int.Parse(s2[2]);

        Console.WriteLine((cx - az) + " " + (cy / ay) + " " + (cz - ax));
    }
}