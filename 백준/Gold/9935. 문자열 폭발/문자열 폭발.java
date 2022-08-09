import java.util.Scanner;
import java.util.Stack;

public class Main {
	public static void main(String[] ags) {
		StringBuilder sb = new StringBuilder();
		Scanner sc = new Scanner(System.in);
		char[] s1 = sc.nextLine().toCharArray();
		char[] s2 = sc.nextLine().toCharArray();
		for (int i = 0; i < s1.length; i++) {
			int idx = 0;
			Stack<Integer> st1 = new Stack<>();
			Stack<Integer> st2 = new Stack<>();
			if (s1[i] == s2[0]) {
				for (i = i; i < s1.length; i++) {
					if (s1[i] == s2[0]) {
						st1.push(i);
						st2.push(idx);
						idx = 1;
					} else if (s1[i] == s2[idx]) {
						st1.push(i);
						idx++;
					} else
						break;
					if (idx == s2.length) {
						for (int j = 0; j < s2.length; j++) {
							s1[st1.pop()] = '\0';
						}
						idx = st2.pop();
					}
				}
				i--;
			}
		}
		boolean check = true;
		for (int i = 0; i < s1.length; i++) {
			if (s1[i] != '\0') {
				sb.append(s1[i]);
				check = false;
			}
		}
		if(check)System.out.print("FRULA");
		else System.out.print(sb);
	}
}