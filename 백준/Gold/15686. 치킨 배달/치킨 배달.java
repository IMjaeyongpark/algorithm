import java.lang.reflect.Array;
import java.util.*;

class lo {
	int x;
	int y;

	lo(int x, int y) {
		this.x = x;
		this.y = y;
	}
}

public class Main {

	static int N, M;
	static LinkedList<lo> ch = new LinkedList<lo>();
	static LinkedList<lo> home = new LinkedList<lo>();
	static int min = Integer.MAX_VALUE;
	static int[][] distance;

	static void bt(int x, int n, LinkedList<Integer> index) {
		if (n >= M) {
			int cur = 0;
			for (int i = 0; i < home.size(); i++) {
				int tmp = Integer.MAX_VALUE;
				for (int idx : index) {
					if (tmp > distance[i][idx])
						tmp = distance[i][idx];
				}
				cur += tmp;
				if (min < cur)
					return;
			}
			min = cur;
			return;
		}
		for (int i = x; i < ch.size(); i++) {
			LinkedList<Integer> tmp = (LinkedList<Integer>) index.clone();
			tmp.add(i);
			bt(i + 1, n + 1, tmp);
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		M = sc.nextInt();
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				int h = sc.nextInt();
				if (h == 1) {
					home.add(new lo(j, i));
				} else if (h == 2) {
					ch.add(new lo(j, i));
				}
			}
		}
		distance = new int[home.size()][ch.size()];
		for (int i = 0; i < home.size(); i++) {
			for (int j = 0; j < ch.size(); j++) {
				distance[i][j] = Math.abs(ch.get(j).x - home.get(i).x) + Math.abs(ch.get(j).y - home.get(i).y);
			}
		}
		bt(0, 0, new LinkedList<Integer>());
		System.out.print(min);
	}
}