import java.util.*;

public class Main {
	static int N, M;
	static int[] sol;
	static int[] cnt;
	static StringBuilder sb = new StringBuilder();
	static ArrayList<Integer> num = new ArrayList<Integer>();

	static void Bt(int x) {
		if (x == M) {
			for (int a : sol) {
				sb.append(a + " ");
			}
			sb.append("\n");
			return;
		}
		for (int n : num) {
			if (cnt[n] > 0) {
				cnt[n]--;
				sol[x] = n;
				Bt(x + 1);
				cnt[n]++;
			}
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		M = sc.nextInt();
		sol = new int[M];
		cnt = new int[10001];
		for (int i = 0; i < N; i++) {
			int tmp = sc.nextInt();
			if (cnt[tmp] == 0) {
				num.add(tmp);
			}
			cnt[tmp]++;
		}
		num.sort(null);
		Bt(0);
		System.out.print(sb);
	}
}