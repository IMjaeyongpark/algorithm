import java.util.*;

public class Main {
	static int[][] sudoku;
	static int cnt = 0;

	static void bt(int x, int count) {

		if (cnt == count) {
			for (int i = 0; i < 9; i++) {
				for (int j = 0; j < 9; j++) {
					System.out.print(sudoku[i][j] + " ");
				}
				System.out.println();
			}
			System.exit(0);
		}
		for (int i = x; i < 81; i++) {
			if (sudoku[i / 9][i % 9] == 0) {
				var check = new boolean[10];
				int[] dx = { 1, -1, 0, 0 };
				int[] dy = { 0, 0, 1, -1 };
				for (int j = 0; j < 4; j++) {
					int nx = i % 9 + dx[j];
					int ny = i / 9 + dy[j];
					while (nx >= 0 && nx < 9 && ny >= 0 && ny < 9) {
						check[sudoku[ny][nx]] = true;
						nx += dx[j];
						ny += dy[j];
					}
				}
				check = ch((i % 9) / 3, (i / 9) / 3, check);
				for (int k = 1; k < 10; k++) {
					if (!check[k]) {
						sudoku[i / 9][i % 9] = k;
						bt(i + 1, count + 1);
						sudoku[i / 9][i % 9] = 0;
					}
				}
				return;
			}
		}
	}

	static boolean[] ch(int x, int y, boolean[] check) {
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				check[sudoku[i + y * 3][j + x * 3]] = true;
			}
		}
		return check;
	}

	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		sudoku = new int[9][9];
		for (int i = 0; i < 9; i++) {
			for (int j = 0; j < 9; j++) {
				sudoku[i][j] = sc.nextInt();
				if (sudoku[i][j] == 0)
					cnt++;
			}
		}
		bt(0, 0);
	}
}