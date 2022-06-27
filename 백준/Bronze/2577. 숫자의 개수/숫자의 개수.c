#include<stdio.h>

int main(void) {
	int a[10] = { 0 }, b, c, d, j;
	scanf("%d\n%d\n%d", &b, &c, &d);
	j = d * b * c;
	for (int k = 10; k <= 10000000000; k *= 10) {
		if (j < k/10)break;
		a[j % k / (k / 10)]++;
	}
	for (int i = 0; i < 10; i++)printf("%d\n", a[i]);
	return 0;
}