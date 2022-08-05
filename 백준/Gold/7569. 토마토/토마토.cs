using System;

class Program
{
   public class loca
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }

    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int x = int.Parse(s[0]);
        int y = int.Parse(s[1]);
        int z = int.Parse(s[2]);
        int[,,] tomato = new int[x, y, z];
        int cnt = 0;
        int count = 0;
        int day = 1;
        Queue<loca> Loca = new Queue<loca>();
        for(int i = 0; i < z; i++)
        {
            for(int j = 0; j < y; j++)
            {
                string[] t = Console.ReadLine().Split();
                for(int k = 0; k < x; k++)
                {
                    int a = int.Parse(t[k]);
                    if (a == 0) cnt++;
                    if (a == 1)
                    {
                        Loca.Enqueue(new loca() { x = k, y = j, z = i });
                    }
                    tomato[k, j, i] = a;
                }
            }
        }
        int[] dx = { 1, -1, 0, 0, 0, 0 };
        int[] dy = { 0, 0, 1, -1, 0, 0 };
        int[] dz = { 0, 0, 0, 0, 1, -1 };
        while(Loca.Count > 0)
        {
            loca toma = Loca.Dequeue();
            for(int i = 0; i < 6; i++)
            {
                int nx = toma.x + dx[i];
                int ny = toma.y + dy[i];
                int nz = toma.z + dz[i];
                if(nx>=0 && ny>=0 && nz>=0&& nx <x && ny <y && nz < z)
                {
                    if (tomato[nx, ny, nz] == 0)
                    {
                        day = tomato[nx, ny, nz] = tomato[toma.x, toma.y, toma.z] + 1;
                        count++;
                        Loca.Enqueue(new loca() { x = nx, y = ny, z = nz });
                    }
                }
            }
        }
        if (cnt != count) day = 0;
        Console.WriteLine(day - 1);
    }
}