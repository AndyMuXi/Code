#include<stdio.h>

void PrintN_x(int N)
{
	int i;
	for (i = 1; i <= N; i++) {
		printf("%d\n", i);
	}
	return;
}

void PrintN_y(int N)
{
	if (N) {
		PrintN_y(N - 1);
		printf("%d\n", N);
	}
}
