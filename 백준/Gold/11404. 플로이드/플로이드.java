import java.lang.reflect.Array;
import java.util.*;

public class Main {
	static private final int INF = 100_000_000;

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		var sb = new StringBuilder();
		int N, M;
		N = sc.nextInt();
		M = sc.nextInt();
		int[][] price = new int[N + 1][N + 1];
		for (int i = 1; i < N + 1; i++) {
			Arrays.fill(price[i], INF);
			price[i][i] = 0;
		}
		for (int i = 0; i < M; i++) {
			int x, y, t;
			x = sc.nextInt();
			y = sc.nextInt();
			t = sc.nextInt();
			if (price[x][y] > t)
				price[x][y] = t;
		}
		for (int k = 1; k < N + 1; k++) {
			for (int i = 1; i < N + 1; i++) {
				for (int j = 1; j < N + 1; j++) {
					if (price[i][j] > price[i][k] + price[k][j]) {
						price[i][j] = price[i][k] + price[k][j];
					}
				}
			}
		}
		for (int i = 1; i < N + 1; i++) {
			for (int j = 1; j < N + 1; j++) {
				if (price[i][j] == INF)
					sb.append(0 + " ");
				else
					sb.append(price[i][j] + " ");
			}
			sb.append("\n");
		}
		System.out.print(sb);
	}
}