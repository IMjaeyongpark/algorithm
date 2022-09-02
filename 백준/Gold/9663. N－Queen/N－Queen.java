import java.util.*;

public class Main {
	static int N;
	static int cnt = 0;

	static void bp(int[] chess, int n) {
		if (n == N) {
			cnt++;
			return;
		}
		for (int i = 0; i < N; i++) {
			if (check(chess, i, n)) {
				chess[n] = i;
				bp(chess, n + 1);
			}
		}
	}

	static boolean check(int[] chess, int i, int n) {
		for (int j = 0; j < n; j++) {
			if (chess[j] - (n - j) == i || chess[j] + (n - j) == i || chess[j] == i)
				return false;
		}
		return true;
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		bp(new int[N], 0);
		System.out.print(cnt);
	}
}