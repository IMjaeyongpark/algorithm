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
	static int start, end;
	static private final int INF = 100_000_000;

	static int dijkstra() {
		var pq = new PriorityQueue<dis>();
		var time = new int[list.length];
		Arrays.fill(time, INF);
		pq.add(new dis(start, 0));
		time[start] = 0;
		while (!pq.isEmpty()) {
			var tmp = pq.poll();
			if (tmp.x == end)
				return time[tmp.x];
			for (var item : list[tmp.x]) {
				if (time[item.x] > time[tmp.x] + item.t) {
					time[item.x] = time[tmp.x] + item.t;
					pq.add(new dis(item.x, time[item.x]));
				}
			}
		}
		return 0;
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		int N, M;
		N = sc.nextInt();
		M = sc.nextInt();
		list = new ArrayList[N + 1];
		for (int i = 1; i < N + 1; i++)
			list[i] = new ArrayList<dis>();
		for (int i = 0; i < M; i++) {
			int x, y, t;
			x = sc.nextInt();
			y = sc.nextInt();
			t = sc.nextInt();
			list[x].add(new dis(y, t));
		}
		start = sc.nextInt();
		end = sc.nextInt();
		System.out.print(dijkstra());
	}
}