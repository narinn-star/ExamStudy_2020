#include <stdio.h>
int main() {
	int n;
	scanf_s("%d", &n);

	for (int i = 1; i <= n; i++){
		for (int j = 0; j < i-1; j++){
			printf(" ");
		}
		for (int k = i; k <= n; k++){
			printf("*");
		}
		printf("\n");
	}
}