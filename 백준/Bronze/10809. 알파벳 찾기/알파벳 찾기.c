#include<stdio.h>

int main() {
	int a[26] ;
	for (int i = 0; i < 26; i++)a[i]=-1;
	char s[100];
	scanf("%s", s);
	for (int k = 0; s[k] != '\0'; k++) {
		for (int i = 0; i < 26; i++) {
			if (s[k] == i+'a') {
				if (a[i] == -1)a[i] = k;
				break;
			}
		}
	}
	for (int i = 0; i < 26; i++)printf("%d ", a[i]);
}