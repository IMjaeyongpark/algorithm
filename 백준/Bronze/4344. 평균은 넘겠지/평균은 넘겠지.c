#include<stdio.h>
int main() {
	int a, b,k,j;
	double c[1000] = { 0 }, sum = 0;
	scanf("%d", &a);
	for (int i = 0; i < a; i++) {
		sum = 0;
		j = 0;
		scanf("%d", &b);
		for (k = 0; k < b; k++) {
			scanf("%lf", &c[k]);
			sum += c[k];
		}
		sum = sum / (double)b;
		for (k = 0; k < b; k++) {
			if (c[k] > sum)j++;
		}

		printf("%.3lf%%\n", j/(double)b*100.0);
	}
	return 0;
}