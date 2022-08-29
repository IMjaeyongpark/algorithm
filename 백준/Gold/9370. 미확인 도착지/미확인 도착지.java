import java.lang.reflect.Array;
import java.util.*;
import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;
import java.util.PriorityQueue;
import java.util.Collections;
import java.util.ArrayList;

class dis implements Comparable<dis> {
	int x;
	int t;

	dis(int x, int t) {
		this.x = x;
		this.t = t;
	}

	public int gett() {
		return this.t;
	}

	@Override
	public int compareTo(dis dis) {

		if (this.t > dis.gett())
			return 1;
		else if (this.t < dis.gett())
			return -1;
		return 0;
	}
}

public class Main {
	static int n, m, t, s, g, h;
	static ArrayList<dis>[] list;
	static private final int INF = 100_000_000;

	static boolean[] dijkstra(int x) {
		var pq = new PriorityQueue<dis>();
		var time = new int[n + 1];
		var sol = new boolean[n + 1];
		Arrays.fill(time, INF);
		time[x] = 0;
		pq.add(new dis(x, 0));
		while (!pq.isEmpty()) {
			var cur = pq.poll();
			for (var tmp : list[cur.x]) {
				if (time[tmp.x] == time[cur.x] + tmp.t) {
					if ((cur.x == g && tmp.x == h) || (cur.x == h && tmp.x == g)|| sol[cur.x])
						sol[tmp.x] = true;
				}
				if (time[tmp.x] > time[cur.x] + tmp.t) {
					if ((cur.x == g && tmp.x == h) || (cur.x == h && tmp.x == g) || sol[cur.x]) {
						sol[tmp.x] = true;
					} else
						sol[tmp.x] = false;
					time[tmp.x] = time[cur.x] + tmp.t;
					pq.add(new dis(tmp.x, time[tmp.x]));
				}
			}
		}
		return sol;
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		var sb = new StringBuilder();
		int T = sc.nextInt();
		for (int k = 0; k < T; k++) {
			n = sc.nextInt();
			m = sc.nextInt();
			t = sc.nextInt();
			s = sc.nextInt();
			g = sc.nextInt();
			h = sc.nextInt();
			list = new ArrayList[n + 1];
			for (int i = 1; i < n + 1; i++)
				list[i] = new ArrayList<dis>();
			for (int i = 0; i < m; i++) {
				int x, y, t;
				x = sc.nextInt();
				y = sc.nextInt();
				t = sc.nextInt();
				list[x].add(new dis(y, t));
				list[y].add(new dis(x, t));
			}
			var sol = dijkstra(s);
			var check = new boolean[n + 1];
			for (int i = 0; i < t; i++) {
				check[sc.nextInt()] = true;
			}
			for (int i = 1; i < n + 1; i++) {
				if (check[i] && sol[i])
					sb.append(i + " ");
			}
			sb.append("\n");
		}
		System.out.print(sb);
	}
}