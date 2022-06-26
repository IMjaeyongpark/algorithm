#include<stdio.h>

int main(void) {
	int a[2]={ -1000000,1000000 };
	int b, c;
	scanf("%d", &b);
	for (int i=0; i < b; i++) {
		scanf("%d", &c);
		if (a[0] <= c)a[0] = c;
		if (a[1] >= c)a[1] = c;
	}
	printf("%d %d", a[1], a[0]);
}