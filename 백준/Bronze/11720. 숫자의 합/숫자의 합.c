#include<stdio.h>

int main() {
	char a[100]={'0'}, b;
	int N,sum=0;
	scanf("%d", &N);
	scanf("%s", a, N);
	for (int i = 0; i < N; i++) {
	    sum+=a[i]-'0';
	}
	printf("%d", sum);
    return 0;
}