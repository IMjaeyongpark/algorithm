import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;

public class Main {
	static int[] dfs;
	static StringBuilder sb = new StringBuilder();
	static void search(int x,int N,int[][] V) {
		dfs[x] = 1;
		sb.append(x + 1 + " ");
		for(int i=0;i<N;i++) {
			if(dfs[i]==0&&V[i][x]==1) {
				search(i,N,V);
			}
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		int N = Integer.parseInt(sc.next());
		int M = Integer.parseInt(sc.next());
		int S = Integer.parseInt(sc.next());
		int[][] V = new int[N][N];
		for (int i = 0; i < M; i++) {
			int x = Integer.parseInt(sc.next()) - 1;
			int y = Integer.parseInt(sc.next()) - 1;
			V[y][x] = 1;
			V[x][y] = 1;
		}
		dfs = new int[N];
		search(S - 1, N, V);
		sb.append("\n");
		
		int[] bfs = new int[N];
		Queue<Integer> q = new LinkedList<>();
		q.offer(S - 1);
		sb.append(S + " ");
		bfs[S - 1] = 1;
		while (!q.isEmpty()) {
			int x = q.poll();
			for (int i = 0; i < N; i++) {
				if (V[i][x] == 1 && bfs[i] == 0) {
					q.offer(i);
					sb.append(i + 1 + " ");
					bfs[i] = 1;
				}
			}
		}
		System.out.print(sb);
	}
}