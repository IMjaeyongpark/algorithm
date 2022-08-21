import java.util.*;
import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;

public class Main {
	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		var sb = new StringBuilder();
		int M = Integer.parseInt(sc.next());
		int N = Integer.parseInt(sc.next());
		int S = Integer.parseInt(sc.next());
		int count = 1;
		boolean[] check = new boolean[M + 1];
		ArrayList<Integer>[] list = new ArrayList[M + 1];
		int[] sol = new int[M + 1];
		Queue<Integer> q = new LinkedList();
		for (int i = 1; i < M + 1; i++)
			list[i] = new ArrayList<Integer>();
		for (int i = 0; i < N; i++) {
			int x = Integer.parseInt(sc.next());
			int y = Integer.parseInt(sc.next());
			list[x].add(y);
			list[y].add(x);
		}
		for (int i = 1; i < M + 1; i++)
			Collections.sort(list[i],Collections.reverseOrder());
		q.offer(S);
		check[S] = true;
		sol[S] = count++;
		while (!q.isEmpty()) {
			int x = q.poll();
			for (int a : list[x]) {
				if (!check[a]) {
					q.offer(a);
					check[a] = true;
					sol[a] = count++;
				}
			}
		}
		for (int i = 1; i < M + 1; i++)
			sb.append(sol[i]+"\n");
		System.out.print(sb);
	}
}