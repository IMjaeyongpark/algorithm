#include <stdio.h>

int main()
{
	int N;
	double arr[1000] = { 0 };
	double max = -1, sum = 0;
	scanf("%d", &N);

	for (int i = 0; i < N; i++)
	{
		scanf("%lf", &arr[i]);

		if (max < arr[i])
			max = arr[i];
	}
	for (int i = 0; i < N; i++)
	{
		arr[i] = arr[i] / max * 100.0;
		sum += arr[i];
	}
	printf("%.2lf", sum / (double)N);
	return 0;
}
