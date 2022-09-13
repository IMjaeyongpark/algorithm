import java.util.*;

class Object {
	int W;
	int V;

	Object(int W, int V) {
		this.W = W;
		this.V = V;
	}
}

public class Main {
	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		int N, K;
		N = sc.nextInt();
		K = sc.nextInt();
		int Max = 0;
		ArrayList<Integer> idx = new ArrayList<Integer>();
		idx.add(0);
		int[] Weight = new int[K + 1];
		Object[] list = new Object[N];
		for (int i = 0; i < N; i++) {
			list[i] = new Object(sc.nextInt(), sc.nextInt());
		}
		for (var cur : list) {
			ArrayList<Integer> tmp = new ArrayList<Integer>();
			int[] temp = Weight.clone();
			for (int index : idx) {
				if (index + cur.W <= K) {
					if (temp[index + cur.W] == 0)
						tmp.add(index + cur.W);
					if (temp[index + cur.W] < Weight[index] + cur.V) {
						temp[index + cur.W] = Weight[index] + cur.V;
						if (temp[index + cur.W] > Max)
							Max = temp[index + cur.W];
					}
				}
			}
			for (var t : tmp) {
				idx.add(t);
			}
			Weight = temp;
		}
		System.out.print(Max);
	}
}