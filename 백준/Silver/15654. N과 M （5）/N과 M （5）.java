import java.lang.reflect.Array;
import java.util.*;

public class Main {
	static int N, M;
	static int[] num;
	static StringBuilder sb = new StringBuilder();

	static void bt(int x, int n, int[] sol, boolean[] check) {
		check[x] = true;
		sol[n-1] = num[x];
		if (n >= M) {
			for (int tmp : sol) {
				sb.append(tmp + " ");
			}
			sb.append("\n");
			return;
		}
		for (int i = 0; i < N; i++) {
			if (!check[i]) {
				bt(i, n + 1, sol.clone(), check.clone());
			}
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		M = sc.nextInt();
		num = new int[N];
		for (int i = 0; i < N; i++)
			num[i] = sc.nextInt();
		Arrays.sort(num);
		int[] sol = new int[M];
		var check = new boolean[N];
		for (int i = 0; i < N; i++) {
			bt(i, 1, sol.clone(), check.clone());
		}
		System.out.print(sb);

	}
}