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
	static PriorityQueue<dis> q = new PriorityQueue<dis>();
	static boolean[] visit;
	static int[] time;
	private static final int INF = 100_000_000;
	static int[] r = new int[2];
	static int[] distance = {0,0,0};

	static void dijkstra(int x, int y, int idx) {
		visit[x] = true;
		if (visit[y]) {
			distance[idx] += time[y];
			return;
		}
		for (var item : list[x]) {
			if (time[item.x] > item.t + time[x]) {
				time[item.x] = item.t + time[x];
				q.add(new dis(item.x, time[item.x]));
			}
		}
		while (!q.isEmpty()) {
			var tmp = q.poll();
			if (!visit[tmp.x]) {
				dijkstra(tmp.x, y, idx);
				break;
			}
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		int N, E;
		N = sc.nextInt();
		E = sc.nextInt();
		list = new ArrayList[N + 1];
		for (int i = 1; i < N + 1; i++)
			list[i] = new ArrayList<dis>();
		for (int i = 0; i < E; i++) {
			int x, y, t;
			x = sc.nextInt();
			y = sc.nextInt();
			t = sc.nextInt();
			list[x].add(new dis(y, t));
			list[y].add(new dis(x, t));
		}
		r[0] = sc.nextInt();
		r[1] = sc.nextInt();

		for (int i = 0; i < 2; i++) {
			for (int j = 0; j < 2; j++) {
				visit = new boolean[N + 1];
				time = new int[N + 1];
				q = new PriorityQueue<dis>();
				Arrays.fill(time, INF);
				if (j == 0) {
					time[1] = 0;
					dijkstra(1, r[(i + j) % 2], i);

					if (!visit[r[(i + j) % 2]]) {
						distance[i] = INF;
						break;
					}
				} else {
					time[r[(i + j) % 2]] = 0;
					dijkstra(r[(i + j) % 2], N, i);
					if (!visit[N]) {
						distance[i] = INF;
						break;
					}
				}
			}
		}
		int sol = distance[0] >= distance[1] ? distance[1] : distance[0];
		visit = new boolean[N + 1];
		time = new int[N + 1];
		q = new PriorityQueue<dis>();
		Arrays.fill(time, INF);
		time[r[0]] = 0;
		dijkstra(r[0], r[1], 2);
		if (sol == INF || !visit[r[1]]) {
			sol = -1;
			distance[2] = 0;
		}
		System.out.print(sol + distance[2]);
	}
}