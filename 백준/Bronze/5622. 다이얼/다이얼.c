#include<stdio.h>

int main() {
	char s[1000000];
	int sum = 0;
	scanf("%s", s);
	for (int i = 0; s[i] != '\0'; i++) {
		if (s[i] <= 'C')sum += 3;
		else if (s[i] <= 'F')sum += 4;
		else if (s[i] <= 'I')sum += 5;
		else if (s[i] <= 'L')sum += 6;
		else if (s[i] <= 'O')sum += 7;
		else if (s[i] <= 'S')sum += 8;
		else if (s[i] <= 'V')sum += 9;
		else if (s[i] <= 'Z')sum += 10;
	}
	printf("%d", sum);
	return 0;
}