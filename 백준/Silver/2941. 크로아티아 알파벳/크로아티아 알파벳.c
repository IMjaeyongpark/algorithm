#include<stdio.h>

int main() {
	char s[1000000];
	int count = 0;
	scanf("%s", s);
	for (int i = 0; s[i] != '\0'; i++) {
		if (s[i] == 's' || s[i] == 'z') {
			if (s[i + 1] == '=') {
				count++;
				i++;
			}
			else count++;
		}
		else if (s[i] == 'c') {
			if (s[i + 1] == '=' || s[i + 1] == '-') {
				count++;
				i++;
			}
			else count++;
		}
		else if (s[i] == 'd') {
			if (s[i + 1] == '-') {
				count++;
				i++;
			}
			else if (s[i+1] == 'z') {
				if (s[i + 2] == '=') {
					count++;
					i += 2;
				}
				else count++;
			}
			else count++;
		}
		else if (s[i] == 'l' || s[i] == 'n') {
			if (s[i + 1] == 'j') {
				count++;
				i++;
			}
			else count++;
		}
		else count++;
	}
	printf("%d", count);
}