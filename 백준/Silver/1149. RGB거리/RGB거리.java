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
		int n = sc.nextInt();
		int[][] rgb = new int[n][3];
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < 3; j++)
				rgb[i][j] = sc.nextInt();
		}
		for (int i = 1; i < n; i++) {
			for (int j = 0; j < 3; j++) {
				int min = Integer.MAX_VALUE;
				for (int k = 0; k < 3; k++) {
					if (j != k && min > rgb[i - 1][k]) {
						min = rgb[i - 1][k];
					}
				}
				rgb[i][j] += min;
			}
		}
		int sol = Integer.MAX_VALUE;
		for (int a : rgb[n - 1]) {
			if (sol > a)
				sol = a;
		}
		System.out.print(sol);
	}
}