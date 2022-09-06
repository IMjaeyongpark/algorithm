import java.lang.reflect.Array;
import java.util.*;
import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;
import java.util.PriorityQueue;
import java.util.Collections;
import java.util.ArrayList;

public class Main {
	static StringBuilder sb = new StringBuilder();
	static int N, M;
	static int[] sol;

	static void bt(int x, int idx, boolean[] check) {
		if (idx == M) {
			for (var a : sol) {
				sb.append(a + " ");
			}
			sb.append("\n");
			return;
		}
		for (int i = 1; i < N + 1; i++) {
			if (!check[i]) {
				sol[idx] = i;
				var tmp = check.clone();
				tmp[i] = true;
				bt(i, idx + 1, tmp);
			}
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		N = sc.nextInt();
		M = sc.nextInt();
		sol = new int[M];
		bt(1, 0, new boolean[N + 1]);
		System.out.print(sb);
	}
}