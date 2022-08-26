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
	static int N, M, X;
	static ArrayList<dis>[] list;
	static int[] time;
	static private final int INF = 100_000_000;

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		M = sc.nextInt();
		X = sc.nextInt();
		list = new ArrayList[N + 1];
		time = new int[N + 1];
		for (int i = 1; i < N + 1; i++)
			list[i] = new ArrayList<dis>();
		for (int i = 0; i < M; i++) {
			int x, y, t;
			x = sc.nextInt();
			y = sc.nextInt();
			t = sc.nextInt();
			list[x].add(new dis(y, t));
		}
		int[] visit = dijkstra(X);
		for (int i = 1; i < N + 1; i++)
			time[i] = dijkstra(i)[X] + visit[i];
		int max = 0;
		for (int a : time) {
			if (max < a && a != INF)
				max = a;
		}
		System.out.println(max);
	}

	static int[] dijkstra(int x) {
		PriorityQueue<dis> pq = new PriorityQueue<dis>();
		int[] visit = new int[N + 1];
		Arrays.fill(visit, INF);
		visit[x] = 0;
		pq.add(new dis(x, 0));
		while (!pq.isEmpty()) {
			var cur = pq.poll();
			for (var item : list[cur.x]) {
				if (visit[item.x] > visit[cur.x] + item.t) {
					visit[item.x] = visit[cur.x] + item.t;
					pq.add(new dis(item.x, visit[item.x]));
				}
			}
		}
		return visit;
	}
}