using System;

class Program{
    static void Main(){
        int N=int.Parse(Console.ReadLine());
        int sum=1;
        for(int i=1;i<=N;i++){
            sum*=i;
        }
        Console.Write(sum);
    }
}