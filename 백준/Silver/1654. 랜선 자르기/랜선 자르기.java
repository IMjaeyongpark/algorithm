import java.util.*;

public class Main {
	static int N, K;
	static long[] length;
	static long sol = 0;

	static void search(long start, long end) {
		long mid = (end + start) / 2;
		if (start > end)
			return;
		long cnt = 0;
		for (int i = 0; i < N && mid > 0; i++) {
			cnt += (length[i] / mid);
		}
		if (cnt >= (long) K && sol < mid) {
			sol = mid;
		}
		if (cnt >= (long) K || mid == 0)
			search(mid + 1, end);
		else
			search(start, mid - 1);

	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		K = sc.nextInt();
		long max = 0;
		length = new long[N];
		for (int i = 0; i < N; i++) {
			length[i] = (long) sc.nextInt();
			if (max < length[i])
				max = length[i];
		}
		search(0, max);
		System.out.print(sol);
	}
}