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
	static PriorityQueue<dis> pq = new PriorityQueue<>();
	static boolean[] visit;
	static int[] time;
	private static final int INF = 100_000_000;

	static void dijkstra(int x) {
		visit[x] = true;
		for (dis item : list[x]) {
			if (time[item.x] > time[x] + item.t) {
				time[item.x] = time[x] + item.t;
				pq.add(new dis(item.x,time[item.x]));
			}
		}
		while (!pq.isEmpty()) {
			dis tmp = pq.poll();
			if (!visit[tmp.x]) {
				dijkstra(tmp.x);
				break;
			}
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		var sb = new StringBuilder();
		int V = sc.nextInt();
		int E = sc.nextInt();
		int S = sc.nextInt();
		list = new ArrayList[V + 1];
		time = new int[V + 1];
		visit = new boolean[V + 1];
		for (int i = 1; i < V + 1; i++)
			list[i] = new ArrayList();
		for (int i = 0; i < E; i++) {
			int x, y, t;
			x = sc.nextInt();
			y = sc.nextInt();
			t = sc.nextInt();
			list[x].add(new dis(y, t));
		}
		Arrays.fill(time, INF);
		time[S] = 0;
		dijkstra(S);
		for (int i = 1; i < V + 1; i++) {
			if (!visit[i])
				sb.append("INF\n");
			else
				sb.append(time[i] + "\n");
		}
		System.out.print(sb);
	}
}