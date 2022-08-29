import java.lang.reflect.Array;
import java.util.*;
import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;
import java.util.PriorityQueue;
import java.util.Collections;
import java.util.ArrayList;
import java.math.*;

public class Main {
	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		int n, m;
		n = sc.nextInt();
		m = sc.nextInt();
		if (n - m < m / 2) {
			m = n - m;
		}

		BigInteger sol = new BigInteger("1");
		for (int i = 0; i < m; i++) {
			String a = "";
			a+=(n-i);
			BigInteger b =  new BigInteger(a);
			sol = sol.multiply(b);
		}
		for (int i = 1; i <= m; i++) {
			String a = "";
			a+=i;
			BigInteger b = new BigInteger(a);
			sol = sol.divide(b);
		}
		System.out.print(sol);
	}
}