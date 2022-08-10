import java.util.Scanner;

public class Main {
	static int[][] G;
	static int[][] sol;

	static void search(int x, int y, int[] check) {
		check[x]++;
		for (int i = 0; i < check.length; i++) {
			if (G[i][x] == 1) {
				sol[i][y] = 1;
				if (check[i] == 0)
					search(i, y, check);
			}
		}
	}

	public static void main(String[] ags) {
		var sb = new StringBuilder();
		Scanner sc = new Scanner(System.in);
		int N = Integer.parseInt(sc.next());
		G = new int[N][N];
		sol = new int[N][N];
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				sol[j][i] = G[j][i] = Integer.parseInt(sc.next());
			}
		}
		for (int i = 0; i < N; i++) {
			int[] check = new int[N];
			for (int j = 0; j < N; j++) {
				if (G[j][i] == 1) {
					search(j, i, check);
				}
			}
		}
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				sb.append(sol[j][i]+" ");
			}
			sb.append("\n");
		}
		System.out.print(sb);
	}
}