import java.util.*;

public class Main {
	static int N, M;
	static int[] length;
	static int max = 0;
	static long sol = 0;

	static void search(int start, int end) {
		int mid = (start + end) / 2;
		if (start > end)		
			return;
		long cur_length = 0;
		for (int i = 0; i < N; i++) {
			int l = length[i] - mid;
			if (l > 0)
				cur_length += l;
		}
		if (cur_length >= M && sol < mid) {
			sol = mid;
		}
		if (cur_length == N)
			return;
		else if (cur_length < M)
			search(start, mid - 1);
		else
			search(mid + 1, end);

	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		M = sc.nextInt();
		length = new int[N];
		for (int i = 0; i < N; i++) {
			length[i] = sc.nextInt();
			if (max < length[i])
				max = length[i];
		}
		search(0, max);
		System.out.print(sol);
	}
}