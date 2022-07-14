using System;
using System.Text;

class Program{
    static void Main(){
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++){
        string s ="NO";
            int count = 0;
            char[] c = Console.ReadLine().ToCharArray();
            for(int j = 0; j < c.Length; j++){
                if(c[j]=='(')count++;
                else if(c[j]==')')count--;
                if(count<0)break;
            }
            if(count==0)s="YES";
            sb.Append(s+"\n");
        }
        Console.WriteLine(sb);
    }
}