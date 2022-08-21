import java.util.*;
import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;

class loca {
	public int x;
	public int y;

	public void lo(int x, int y) {
		this.x = x;
		this.y = y;
	}
}

public class Main {
	public static void main(String[] ags) {
		ArrayList<loca> list = new ArrayList<loca>();
		var sc = new Scanner(System.in);
		var sb = new StringBuilder();
		int[] dx = { 1, 1, -1, -1, 2, 2, -2, -2 };
		int[] dy = { 2, -2, 2, -2, 1, -1, 1, -1 };
		int N = Integer.parseInt(sc.next());
		Queue<loca> q;
		for (int i = 0; i < N; i++) {
			q = new LinkedList();
			int size = Integer.parseInt(sc.next());
			int[][] check = new int[size][size];
			loca start = new loca();
			int x = Integer.parseInt(sc.next());
			int y = Integer.parseInt(sc.next());
			start.lo(x, y);
			loca end = new loca();
			x = Integer.parseInt(sc.next());
			y = Integer.parseInt(sc.next());
			end.lo(x, y);
			q.offer(start);
			while (!q.isEmpty()) {
				loca tmp = q.poll();
				if (tmp.x == end.x && tmp.y == end.y) {
					sb.append(check[end.x][end.y] + "\n");
					break;
				}
				for (int j = 0; j < 8; j++) {
					int nx = tmp.x + dx[j];
					int ny = tmp.y + dy[j];
					if (nx >= 0 && ny >= 0 && nx < size && ny < size) {
						if (check[nx][ny] == 0) {
							check[nx][ny] = check[tmp.x][tmp.y] + 1;
							loca temp = new loca();
							temp.x = nx;
							temp.y = ny;
							q.offer(temp);
						}
					}
				}
			}
		}
		System.out.print(sb);
	}
}