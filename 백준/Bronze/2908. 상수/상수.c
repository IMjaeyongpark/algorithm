#include<stdio.h>

int main() {
	char a[3], b[3];
	int i;
	scanf("%s\n%s", a, b);
	for (i = 2; a[i] == b[i]; i--);
	if (a[i] > b[i]) {
		for (int k = 2; k >= 0; k--)printf("%c", a[k]);
	}
	else {
		for (int k = 2; k >= 0; k--)printf("%c", b[k]);
	}
}