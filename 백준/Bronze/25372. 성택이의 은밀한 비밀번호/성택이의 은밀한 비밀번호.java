import java.util.*;

public class Main {

	public static void main(String[] args) {
		var sb = new StringBuilder();
		var sc = new Scanner(System.in);
		int n = sc.nextInt();
		for (int i = 0; i < n; i++) {
			String s = sc.next();
			if (s.length() >= 6 && s.length() <= 9) {
				sb.append("yes\n");
			} else {
				sb.append("no\n");
			}
		}
		System.out.print(sb);
	}

}
