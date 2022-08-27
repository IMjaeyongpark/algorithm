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
	static ArrayList<dis>[] list;
	static int N;
	static int[][] time;
	static StringBuilder sb = new StringBuilder();
	static private final int INF = 100_000_000;

	static void dijkstra(int x) {
		var pq = new PriorityQueue<dis>();
		Arrays.fill(time[x], INF);
		time[x][x] = 0;
		var visit = new boolean[N + 1];
		pq.add(new dis(x, 0));
		while (!pq.isEmpty()) {
			var cur = pq.poll();
			if (!visit[cur.x]) {
				for (var tmp : list[cur.x]) {
					if (time[x][tmp.x] > time[x][cur.x] + tmp.t) {
						time[x][tmp.x] = time[x][cur.x] + tmp.t;
						pq.add(new dis(tmp.x, time[x][tmp.x]));
					}
				}
			}
			visit[cur.x] = true;
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		int M;
		N = sc.nextInt();
		M = sc.nextInt();
		list = new ArrayList[N + 1];
		time = new int[N + 1][N + 1];
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
		int min = INF;
		for (int i = 1; i < N; i++) {
			for (int j = i + 1; j < N + 1; j++) {
				int a = time[i][j] + time[j][i];
				if (min > a)
					min = a;
			}
		}
		if (min >= INF)
			min = -1;
		System.out.print(min);
	}
}