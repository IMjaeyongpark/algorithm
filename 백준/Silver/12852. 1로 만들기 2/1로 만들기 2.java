import java.lang.reflect.Array;
import java.util.*;
import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;
import java.util.PriorityQueue;
import java.util.Collections;
import java.util.ArrayList;

public class Main {
	public static void main(String[] ags) {
		Queue<Integer> q = new LinkedList();
		var sc = new Scanner(System.in);
		int N = sc.nextInt();
		var bfs = new int[N + 1];
		var route = new int[N + 1];
		q.add(N);
		while (!q.isEmpty()) {
			int cur = q.poll();
			if (cur % 2 == 0 && cur / 2 > 0) {
				if (bfs[cur / 2] == 0) {
					bfs[cur / 2] = bfs[cur] + 1;
					route[cur / 2] = cur;
					q.add(cur / 2);
				}
			}
			if (cur % 3 == 0 && cur / 3 > 0) {
				if (bfs[cur / 3] == 0) {
					bfs[cur / 3] = bfs[cur] + 1;
					route[cur / 3] = cur;
					q.add(cur / 3);
				}
			}
			if (cur > 1 && bfs[cur - 1] == 0) {
				bfs[cur - 1] = bfs[cur] + 1;
				route[cur - 1] = cur;
				q.add(cur - 1);
			}

		}
		var sol = new int[bfs[1]];
		int pre = 1;
		for (int i = sol.length - 1; i >= 0; i--) {
			sol[i] = pre;
			pre = route[pre];
		}
		System.out.println(bfs[1]);
		System.out.print(N + " ");
		for (int a : sol)
			System.out.print(a + " ");
	}
}