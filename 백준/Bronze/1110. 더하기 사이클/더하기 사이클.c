#include<stdio.h>

int main(void) {
	int a,b=0,c,i=0;
	scanf("%d", &a);
	b = a;
	do{
		c = b / 10 + b % 10;
		b = b % 10 * 10 + c % 10;
		i++;
	} while (b != a);
	printf("%d", i);
}