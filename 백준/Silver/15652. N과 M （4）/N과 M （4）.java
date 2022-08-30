import java.lang.reflect.Array;
import java.util.*;

public class Main {
	static int N, M;
	static StringBuilder sb = new StringBuilder();

	static void bt(int x, int n, int[] sol) {
		if (n >= M) {
			for (int tmp : sol) {
				sb.append(tmp + " ");
			}
			sb.append("\n");
			return;
		}
		for (int i = x; i <= N; i++) {
			sol[n] = i;
			bt(i, n + 1, sol.clone());
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		M = sc.nextInt();
		int[] sol = new int[M];
		bt(1, 0, sol.clone());
		System.out.print(sb);

	}
}