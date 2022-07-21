using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Stack<char> stack = new Stack<char>();
            bool check = true;
            string s = Console.ReadLine();
            if (s == ".") break;
            foreach(var c in s)
            {
                if (c == '(' || c == '[') stack.Push(c);
                else if (c == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        check = false;
                        break;
                    }
                }
                else if (c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != '[')
                    {
                        check = false;
                        break;
                    }
                }
            }
            if (check && stack.Count == 0) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}