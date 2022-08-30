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
		int T = sc.nextInt();
		for (int i = 0; i < T; i++) {
			int n = sc.nextInt();
			int[][] dp = new int[2][n + 1];
			for (int j = 0; j < 2; j++) {
				for (int k = 1; k < n + 1; k++) {
					dp[j][k] = sc.nextInt();
				}
			}
			for (int j = 1; j < n + 1; j++) {
				for (int k = 0; k < 2; k++) {
					if (j < 3) {
						dp[k][j] += dp[(k + 1) % 2][j - 1];
					} else {
						dp[k][j] += dp[(k + 1) % 2][j - 1] >= dp[(k + 1) % 2][j - 2] ? dp[(k + 1) % 2][j - 1] : dp[(k + 1) % 2][j - 2];
					}
				}
			}
			sb.append(dp[0][n] >= dp[1][n] ? dp[0][n] : dp[1][n] );
			sb.append("\n");
		}
		System.out.print(sb);
	}
}