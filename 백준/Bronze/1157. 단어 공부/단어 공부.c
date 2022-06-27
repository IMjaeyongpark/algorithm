#include<stdio.h>

int main() {
	char s[1000000];
	int a[26] = { 0 }, k, j = 0, num = 0, x = 0;
	scanf("%s", s);
	for (int i = 0; s[i] != '\0'; i++) {
		k = s[i] - 'a';
		if (k < 0)k = k + 32;
		a[k]++;
	}
	for (int i = 0; i < 26; i++) {
		if (x < a[i]) {
			x = a[i];
			num = i;
			j = 0;
		}
		else if (x == a[i])j++;
	}
	if (j == 0)printf("%c", num + 65);
	else printf("?");
}