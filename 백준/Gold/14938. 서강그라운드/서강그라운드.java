import java.lang.reflect.Array;
import java.util.*;
import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;
import java.util.PriorityQueue;
import java.util.Collections;

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
	static ArrayList<dis>[] list;
	static int[] item;
	static int m, n;
	static int max = 0;
	static private final int INF = 100_000_000;

	static void dijkstra(int x) {
		var pq = new PriorityQueue<dis>();
		var time = new int[n + 1];
		var visit = new boolean[n + 1];
		Arrays.fill(time, INF);
		int it = 0;
		pq.add(new dis(x, 0));
		time[x] = 0;
		while (!pq.isEmpty()) {
			var tmp = pq.poll();
			while (visit[tmp.x] && !pq.isEmpty())
				tmp = pq.poll();
			if (tmp.t > m || visit[tmp.x])
				break;
			visit[tmp.x] = true;
			it += item[tmp.x];
			for (var route : list[tmp.x]) {
				if (time[route.x] > time[tmp.x] + route.t) {
					time[route.x] = time[tmp.x] + route.t;
					pq.add(new dis(route.x, time[route.x]));
				}
			}
		}
		if (max < it)
			max = it;

	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		int r;
		n = sc.nextInt();
		m = sc.nextInt();
		r = sc.nextInt();
		list = new ArrayList[n + 1];
		for (int i = 1; i < n + 1; i++)
			list[i] = new ArrayList<dis>();
		item = new int[n + 1];
		for (int i = 1; i < n + 1; i++)
			item[i] = sc.nextInt();
		for (int i = 0; i < r; i++) {
			int x, y, t;
			x = sc.nextInt();
			y = sc.nextInt();
			t = sc.nextInt();
			list[x].add(new dis(y, t));
			list[y].add(new dis(x, t));
		}
		for (int i = 1; i < n + 1; i++) {
			dijkstra(i);
		}
		System.out.print(max);
	}
}