using System;
using System.Text;

class Program
{
    public  struct id
    {
        public int age;
        public string name;
    }
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int N = int.Parse(Console.ReadLine());
        string[] id = new string[N];
        id[] ids = new id[N];
        for(int i = 0; i < N; i++)
        {
            string[] s = Console.ReadLine().Split();
            ids[i].age = int.Parse(s[0]);
            ids[i].name = s[1];
        }
        var result = ids.OrderBy(i => i.age).ThenByDescending(i => i.age).Select(i => i);
        foreach(var a in result)
        {
            sb.Append(a.age + " " + a.name + "\n");
        }
        Console.WriteLine(sb.ToString());

    }
}