import java.lang.reflect.Array;
import java.util.*;

public class Main {
	public static void main(String[] ags) {
		var sc = new Scanner(System.in);
		var sb = new StringBuilder();
		Stack<Character> st = new Stack<Character>();
		String sik = sc.next();
		for (int i = 0; i < sik.length(); i++) {
			char cur = sik.charAt(i);
			if (cur >= 65 && cur <= 90) {
				sb.append(cur);
			} else if (cur == '+' || cur == '-' || cur == '/' || cur == '*') {
				while (!st.isEmpty() && check(st.peek()) >= check(cur)) {
					sb.append(st.pop());
				}
				st.push(cur);
			} else if (cur == ')') {
				while (!st.isEmpty() && st.peek() != '(') {
					sb.append(st.pop());
				}
				st.pop();
			}

			else {
				st.push(cur);
			}
		}
		while (!st.isEmpty()) {
			sb.append(st.pop());
		}
		System.out.println(sb);
	}

	static int check(Character t) {
		if (t == '(' || t == ')') {
			return 0;
		} else if (t == '*' || t == '/') {
			return 2;
		} else if (t == '+' || t == '-') {
			return 1;
		}
		return -1;
	}
}