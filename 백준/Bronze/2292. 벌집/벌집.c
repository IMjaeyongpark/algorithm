#include<stdio.h>

int main() {
	int i=1, n,count=0;
	scanf("%d", &n);
	while (i < n) {
		count++;
		i += count * 6;
	}
	printf("%d", count+1);
}