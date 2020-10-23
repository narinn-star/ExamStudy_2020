#include <stdio.h>
int main() {
	int n;
	scanf_s("%d", &n);

	for (int i = 1; i <= n; i++) {
		for (int j = i; j < n; j++) {
			printf(" ");
		}
			printf("*");
		for (int l = 2; l < 2 * i - 1; l++) {
			printf(" ");
		}
		if (i == 1) {
			printf("");
		}
		else {
			for (int m = i; m <= i; m++) {
				printf("*");
			}
		}
		printf("\n");
	}
	for (int i = 1; i < n; i++) {
		for (int j = 1; j <= i; j++) {
			printf(" ");
		}
			printf("*");
		for (int l = i; l < n-1; l++) {
			printf(" ");
		}
		for (int m = i; m < n - 2; m++) {
			printf(" ");
		}
		if (i < n-1) {
				printf("*");
		}

		printf("\n");
	}
}