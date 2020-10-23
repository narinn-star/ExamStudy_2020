#include <stdio.h>
int main() {
	int n;
	scanf_s("%d", &n);

	for (int i = 1; i <= n; i++) {
		for (int j = i; j <= n ; j++) {
			printf("*");
		}
		for (int k = 1; k <= 2 * i - 1; k++) {
			printf(" ");
		}
		for (int l = i; l <= n; l++) {
			printf("*");
		}
		printf("\n");
	}
	for (int i = 1; i <= 2 * n +1; i++) {
		printf(" ");
	}
	printf("\n");
	for (int i = 1; i <= n; i++) {
		for (int j = 1; j <= i; j++) {
			printf("*");
		}
		for (int k = i; k <= n; k++) {
			printf(" ");
		}
		for (int l = i; l < n; l++) {
			printf(" ");
		}
		for (int m = 1; m <= i; m++) {
			printf("*");
		}
		printf("\n");
	}
}