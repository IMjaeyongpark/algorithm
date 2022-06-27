#include<stdio.h>
#include<string.h>

int main() {
	char a[80] = { 0 };
	int N,score,b;
	scanf("%d", &N);
	for (int i = 0; i < N; i++) {
		score = 0;
		b = 0;
		scanf("%s", a, 80);
		for (int k = 0; a[k] == 'O' || a[k] == 'X'; k++) {
			if (a[k] == 'O')score += ++b;
			else b = 0;
		}
		printf("%d\n", score);
	}
	return 0;
}