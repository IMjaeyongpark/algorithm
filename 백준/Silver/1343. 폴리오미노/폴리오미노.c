#include<stdio.h>
#include<string.h>

int main() {
	char a[50] = { '\0' };
	scanf("%s", a);
	int X = 0;
	int i;
	int e = 0;
	for (i = 0; a[i] != '\0'; i++) {
		if (a[i] == 'X') {
			X++;
			a[i] = 'A';
		}
		else if (a[i] == '.') {
			if (X == 2) {
				for (int j = i - 2; j < i; j++) {
					a[j] = 'B';
				}
				X = 0;
			}
			else if (X == 0);
			else {
				e = 1;
				break;
			}
		}
		if (X == 4) {
			X = 0;
		}
	}
	if (X == 2) {
		for (int j = i - 2; j < i; j++) {
			a[j] = 'B';
		}
		X = 0;
	}
	else if (X == 0);
	else {
		e = 1;
	}
	if (e == 0) {
		for (int j = 0; a[j] != '\0'; j++) {
			printf("%c", a[j]);
		}
	}
	else {
		printf("-1");
	}
}