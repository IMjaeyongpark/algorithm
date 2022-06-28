#include<stdio.h>

int main() {
	int a=1, b=1, n, k = 1;
	scanf("%d", &n);
	for (int i = 1; i < n; i++) {
		if (k == 1) {
			b++;
			a--;
			if (a <= 0) {
				a++;
				k = 0;
			}
		}
		else if (k == 0) {
			a++;
			b--;
			if (b <= 0) {
				b++;
				k = 1;
			}
		}
	}
	printf("%d/%d", a, b);
}