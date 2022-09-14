import java.util.*;

public class Main {
	static int N, M;
	static int[] sol;
	static boolean[] check = new boolean[10001];
	static StringBuilder sb = new StringBuilder();
	static ArrayList<Integer> num = new ArrayList<Integer>();

	static void Bt(int x, int cur) {
		if (x == M) {
			for (int a : sol) {
				sb.append(a + " ");
			}
			sb.append("\n");
			return;
		}
		for (int i = cur; i < num.size(); i++) {
			sol[x] = num.get(i);
			Bt(x + 1, i);
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		M = sc.nextInt();
		sol = new int[M];
		for (int i = 0; i < N; i++) {
			int tmp = sc.nextInt();
			if (!check[tmp]) {
				num.add(tmp);
				check[tmp] = true;
			}
		}
		num.sort(null);
		Bt(0, 0);
		System.out.print(sb);
	}
}