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
	ArrayList<Integer> route;

	dis(int x, int t) {
		this.x = x;
		this.t = t;
	}

	dis(int x, int t, ArrayList<Integer> route) {
		this.x = x;
		this.t = t;
		this.route = route;
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

class sol {
	int t;
	ArrayList<Integer> route;
}

public class Main {
	static ArrayList<dis>[] list;
	static int N;
	static StringBuilder sb = new StringBuilder();
	static StringBuilder sb2 = new StringBuilder();
	static private final int INF = 100_000_000;

	static void dijkstra(int x) {
		var pq = new PriorityQueue<dis>();
		var time = new sol[N + 1];
		for (int i = 1; i < N + 1; i++) {
			time[i] = new sol();
			time[i].t = INF;
			time[i].route = new ArrayList<Integer>();
		}
		time[x].t = 0;
		time[x].route.add(x);
		var visit = new boolean[N + 1];
		var a = new ArrayList<Integer>();
		a.add(x);
		pq.add(new dis(x, 0, a));
		while (!pq.isEmpty()) {
			var cur = pq.poll();
			if (!visit[cur.x]) {
				for (var tmp : list[cur.x]) {
					if (time[tmp.x].t > time[cur.x].t + tmp.t) {
						time[tmp.x].t = time[cur.x].t + tmp.t;
						var temp = (ArrayList<Integer>) cur.route.clone();
						temp.add(tmp.x);
						time[tmp.x].route = temp;
						pq.add(new dis(tmp.x, time[tmp.x].t, temp));
					}
				}
			}
			visit[cur.x] = true;
		}
		for (int i = 1; i < N + 1; i++) {
			if (time[i].t == INF || time[i].t == 0) {
				sb.append(0 + " ");
				sb2.append("0\n");
			}
			else {
				sb.append(time[i].t + " ");
				sb2.append(time[i].route.size() + " ");
				for (int b : time[i].route) {
					sb2.append(b + " ");
				}
				sb2.append("\n");
			}
		}

		sb.append("\n");
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		int M;
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
		for (int i = 1; i < N + 1; i++)
			dijkstra(i);
		System.out.print(sb);
		System.out.print(sb2);
	}
}