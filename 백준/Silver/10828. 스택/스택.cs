using System;
using System.Text;

class Program{
    static void Main(){
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        for(int i = 0; i < N; i++){
            string[] s =Console.ReadLine().Split();
            if(s[0]=="push"){
                list.Add(int.Parse(s[1]));
            }
            else if(s[0]=="pop"){
                if(list.Count>0){
                sb.Append(list[list.Count-1]+"\n");
                list.RemoveAt(list.Count-1);
                }
                else sb.Append(-1+"\n");
            }
            else if(s[0]=="size"){
                sb.Append(list.Count+"\n");
            }
            else if(s[0]=="empty"){
                if(list.Count==0)sb.Append(1+"\n");
                else sb.Append(0+"\n");
            }
            else if(s[0]=="top"){
                if(list.Count>0){
                sb.Append(list[list.Count-1]+"\n");
                }
                else sb.Append(-1+"\n");
            }
        }
        Console.WriteLine(sb);
    }
}