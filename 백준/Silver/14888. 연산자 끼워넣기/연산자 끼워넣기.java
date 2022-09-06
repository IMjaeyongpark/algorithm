import java.util.*;

public class Main {
	static int[] num;
	static int N;
	static int[] cnt = new int[4];
	static int max = Integer.MIN_VALUE;
	static int min = Integer.MAX_VALUE;

	static void bt(int result, int count) {
		if (N == count) {
			if (max < result)
				max = result;
			if (min > result)
				min = result;
			return;
		}
		for (int i = 0; i < 4; i++) {
			if (cnt[i] > 0) {
				cnt[i]--;
				if (i == 0)
					bt(result + num[count], count + 1);
				else if (i == 1)
					bt(result - num[count], count + 1);
				else if (i == 2)
					bt(result * num[count], count + 1);
				else if (i == 3)
					bt(result / num[count], count + 1);
				cnt[i]++;
			}
		}

	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		num = new int[N];
		for (int i = 0; i < N; i++)
			num[i] = sc.nextInt();

		for (int i = 0; i < 4; i++)
			cnt[i] = sc.nextInt();
		bt(num[0], 1);
		System.out.print(max + "\n" + min);
	}
}