import java.util.*;
import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;


public class Main {
	static ArrayList<Integer>[] list;
	static boolean[] check;
	static int[] sol;
	static int count = 1;

	static void dfs(int x) {
		sol[x] = count++;
		check[x] = true;
		for (int a : list[x]) {
			if (!check[a]) {
				dfs(a);
			}
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		var sb = new StringBuilder();
		int M = Integer.parseInt(sc.next());
		int N = Integer.parseInt(sc.next());
		int S = Integer.parseInt(sc.next());
		list = new ArrayList[M + 1];
		check = new boolean[M + 1];
		sol = new int[M + 1];
		for (int i = 1; i < M + 1; i++)
			list[i] = new ArrayList<>();
		for (int i = 0; i < N; i++) {
			int x = Integer.parseInt(sc.next());
			int y = Integer.parseInt(sc.next());
			list[x].add(y);
			list[y].add(x);
		}
		for (int i = 1; i < M + 1; i++)
			Collections.sort(list[i],Collections.reverseOrder());
		dfs(S);
		for (int i = 1; i < M + 1; i++) {
			sb.append(sol[i] + "\n");
		}
		System.out.print(sb);
	}
}