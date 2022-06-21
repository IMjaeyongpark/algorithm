#include<stdio.h>

int main() {
	int count = 0, k = 0,i;
	char s[1000000];
	gets(s);
	for (i = 0; s[i] != '\0'; i++) {
		if (s[i] == ' ') {
			if (k == 1)count++;
			k = 0;
		}
		else k = 1;
	}
	if (k == 1)count++;
	printf("%d", count);
	return 0;
}