#include<stdio.h>

int main() {
	char s[1000000];
	int N, a[26] = { 0 }, count=0;
	scanf("%d", &N);
	for (int i = 0; i < N; i++) {
		scanf("%s", s);
		for (int k = 0; s[k] != '\0'; k++) {
			if (a[s[k] - 'a'] == 0) {
				while (1) {
					if (s[k] == s[k + 1])k++;
					else {
						a[s[k] - 'a']++;
						break;
					}
				}
				if (s[k + 1] == '\0')count++;
			}
			else break;
		}
		for (int j = 0; j < 26; j++)a[j] = 0;
	}
	printf("%d\n", count);
}