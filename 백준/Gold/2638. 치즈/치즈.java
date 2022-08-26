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
	static int[][] cheese;
	static int[][] visit;
	static Queue<lo> q;
	static int X, Y, day = 1, sol = 1;
	static int[] dx = { 0, 0, -1, 1 };
	static int[] dy = { 1, -1, 0, 0 };

	static void search(int x1, int y1) {
		cheese[x1][y1] = 2;
		for (int i = 0; i < 4; i++) {
			int nx = x1 + dx[i];
			int ny = y1 + dy[i];
			if (nx >= 0 && nx < X && ny >= 0 && ny < Y) {
				if (cheese[nx][ny] == 0) {
					cheese[x1][y1] = 2;
					search(nx, ny);
				}
				if (cheese[nx][ny] == 1) {
					int count = 0;
					for (int k = 0; k < 4; k++) {
						int nx2 = nx + dx[k];
						int ny2 = ny + dy[k];
						if (nx2 >= 0 && nx2 < X && ny2 >= 0 && ny2 < Y) {
							if (cheese[nx2][ny2] == 2)
								count++;
						}
					}
					if (count >= 2) {
						sol = visit[nx][ny] = day;
						q.add(new lo(nx, ny));
						cheese[nx][ny] = 3;
					}
				}
			}
		}
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		q = new LinkedList<lo>();
		Y = sc.nextInt();
		X = sc.nextInt();
		cheese = new int[X][Y];
		visit = new int[X][Y];
		for (int i = 0; i < Y; i++) {
			for (int j = 0; j < X; j++) {
				cheese[j][i] = sc.nextInt();
			}
		}
		for (int i = 0; i < Y; i++) {
			if (cheese[0][i] == 0) {
				cheese[0][i] = 2;
				search(0, i);
			}
			if (cheese[X - 1][i] == 0) {
				cheese[X - 1][i] = 2;
				search(X - 1, i);
			}
		}
		for (int i = 0; i < X; i++) {
			if (cheese[i][0] == 0) {
				search(i, 0);
			}
			if (cheese[i][Y - 1] == 0) {
				cheese[i][Y - 1] = 2;
				search(0, Y - 1);
			}
		}
		
		while (!q.isEmpty()) {
			var cur = q.poll();
			cheese[cur.x][cur.y] = 2;
			day = visit[cur.x][cur.y] + 1;
			cheese[cur.x][cur.y] = 2;
			search(cur.x, cur.y);
		}
		System.out.print(sol);
	}
}