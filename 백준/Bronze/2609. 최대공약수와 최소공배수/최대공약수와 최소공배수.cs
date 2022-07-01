using System;
using System.Text;

class Program
{
   
    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int num1 = int.Parse(s[0]);
        int num2 = int.Parse(s[1]);
        int num = num1<=num2 ? num1 : num2;
        int N = 1;
        
        for(int i = num; i >0; i--)
        {
            if (num1 % i == 0 && num2 % i == 0)
            {
                N = i;
                break;
            } 
        }
        int n1=num1,n2=num2;
        while (n1 != n2)
        {
            if (n1 > n2)
            {
                n2 += num2;
            }
            else n1 += num1;
        }
        Console.WriteLine(N + "\n" + n1);
    }
}
