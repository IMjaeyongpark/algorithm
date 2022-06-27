#include<stdio.h>

int aaaa(int a, int b, int c);

int main() {
	int a, b, c, count;
	scanf("%d\n%d\n%d", &a, &b, &c);
	count = aaaa(a, b, c);
	printf("%d", count);
	return 0;
}

int aaaa(int a, int b, int c) {
	int i;
	if (c - b > 0) {
		i = a / (c - b);
	}
	else return -1;
	return ++i;
}