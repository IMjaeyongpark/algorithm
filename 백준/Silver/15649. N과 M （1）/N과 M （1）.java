
import java.util.*;

public class Main {
	static StringBuilder sb = new StringBuilder();
	static int N, M;
	static int[] sol;
	static boolean[] check;

	static void bt(int x, int idx) {
		if (idx == M) {
			for (var a : sol) {
				sb.append(a + " ");
			}
			sb.append("\n");
			return;
		}
		for (int i = 1; i < N + 1; i++) {
			if (!check[i]) {
				sol[idx] = i;
				check[i] = true;
				bt(i, idx + 1);
				check[i] = false;
			}
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		M = sc.nextInt();
		sol = new int[M];
		check = new boolean[N + 1];
		bt(1, 0);
		System.out.print(sb);
	}
}