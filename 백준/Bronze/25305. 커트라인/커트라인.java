import java.util.*;

public class Main {
	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		int n = sc.nextInt();
		int k = sc.nextInt();
		int[] score = new int[n];
		for(int i= 0;i<n;i++) {
			score[i]= sc.nextInt();
		}
		Arrays.sort(score);
		System.out.print(score[n-k]);
	}
}