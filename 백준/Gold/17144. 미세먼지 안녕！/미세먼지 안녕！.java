import java.lang.reflect.Array;
import java.util.*;
import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;
import java.util.PriorityQueue;
import java.util.Collections;
import java.util.ArrayList;

class lo {
	int x;
	int y;

	lo(int x, int y) {
		this.x = x;
		this.y = y;
	}
}

public class Main {
	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		int R, C, T;
		R = sc.nextInt();
		C = sc.nextInt();
		T = sc.nextInt();
		int[][] cur = new int[C][R];
		int[][] next = new int[C][R];
		int dust = 0;
		int[] y = { -1, -1 };
		boolean check = true;

		for (int i = 0; i < R; i++) {
			for (int j = 0; j < C; j++) {
				int a = sc.nextInt();
				cur[j][i] = a;
				if (a != -1 && a != 0) {
					dust += a;
				}
				if (a == -1 && check) {
					y[0] = i;
					y[1] = i + 1;
					check = false;
				}
			}
		}
		int[] dx = { 0, 0, 1, -1 };
		int[] dy = { 1, -1, 0, 0 };
		for (int i = 0; i < T; i++) {
			next = new int[C][R];
			for (int j = 0; j < R; j++) {
				for (int k = 0; k < C; k++) {
					if (cur[k][j] > 0) {
						int d = cur[k][j] / 5;
						for (int c = 0; c < 4; c++) {
							int nx = k + dx[c];
							int ny = j + dy[c];
							if (nx >= 0 && ny >= 0 && nx < C && ny < R) {
								if (!(nx == 0 && (ny == y[0] || ny == y[1]))) {
									next[nx][ny] += d;
									cur[k][j] -= d;
								}
							}
						}
						next[k][j] += cur[k][j];
					}
				}
			}
			
			dust -= (next[0][y[0] - 1] + next[0][y[1] + 1]);
			for (int j = y[0] - 2; j >= 0; j--) {
				next[0][j + 1] = next[0][j];
			}
			for (int j = 1; j < C; j++) {
				next[j - 1][0] = next[j][0];
			}
			for (int j = 1; j <= y[0]; j++) {
				next[C - 1][j - 1] = next[C - 1][j];
			}
			for (int j = C - 1; j > 1; j--) {
				next[j][y[0]] = next[j - 1][y[0]];
			}
			next[1][y[0]] = 0;

			for (int j = y[1] + 2; j < R; j++) {
				next[0][j - 1] = next[0][j];
			}
			for (int j = 1; j < C; j++) {
				next[j - 1][R - 1] = next[j][R - 1];
			}
			for (int j = R - 1; j >= y[1]; j--) {
				next[C - 1][j] = next[C - 1][j-1];
			}
			for (int j = C - 1; j > 1; j--) {
				next[j][y[1]] = next[j - 1][y[1]];
			}
			next[1][y[1]] = 0;
			
			cur = next;
		}
		System.out.print(dust);
	}
}