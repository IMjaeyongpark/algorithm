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
		var sc = new Scanner(System.in);
		var sb = new StringBuilder();
		int N, M;
		N = sc.nextInt();
		M = sc.nextInt();
		int[][] dp = new int[N + 1][N + 1];
		for (int y = 1; y < N + 1; y++) {
			for (int x = 1; x < N + 1; x++) {
				dp[y][x] = dp[y][x - 1] + sc.nextInt();
			}
		}
		for (int i = 0; i < M; i++) {
			int x1, y1, x2, y2;
			int sum = 0;
			x1 = sc.nextInt();
			y1 = sc.nextInt();
			x2 = sc.nextInt();
			y2 = sc.nextInt();
			for (int j = x1; j <= x2; j++) {
				sum += (dp[j][y2] - dp[j][y1 - 1]);
			}
			sb.append(sum + "\n");
		}
		System.out.print(sb);
	}
}