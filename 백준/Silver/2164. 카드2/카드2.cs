using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Queue<int> card = new Queue<int>();
        for(int i = 1; i <= N; i++)
        {
            card.Enqueue(i);
        }
        bool cardout = true;
        while (card.Count > 1)
        {
            if (cardout)
            {
                card.Dequeue();
                cardout = false;
            }
            else
            {
                int back = card.Dequeue();
                card.Enqueue(back);
                cardout = true;
            }
        }
        Console.WriteLine(card.Dequeue());
    }
}