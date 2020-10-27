#include <stdio.h>
int main() {
	//1)
	/*for (int i = 1; i <= 9; i++) {
		printf("*");
	}
	printf("\n");
	
	for (int i = 1; i <= 7; i++) {
		printf("*");
		for (int j = 1; j <= 7; j++) {
			printf(" ");
		}
		printf("*");
		printf("\n");
	}

	for (int i = 1; i <= 9; i++) {
		printf("*");
	}*/
	
	//2)
	/*for (int i = 1; i <= 4; i++) {
		for (int j = i; j <= 4; j++) {
			printf(" ");
		}
		for (int k = 1; k <= 2 * i - 1; k++) {
			printf("*");
		}
		printf("\n");
	}
	for (int i = 1; i <= 9; i++) {
		printf("*");
	}
	printf("\n");
	for (int i = 1; i <= 4; i++) {
		for (int j = 1; j <= i; j++) {
			printf(" ");
		}
		for (int k = i; k <= 4; k++) {
			printf("*");
		}
		for (int l = i; l <= 3; l++) {
			printf("*");
		}
		printf("\n");
	}*/
	//3)
	/*for (int i = 1; i <= 9; i++) {
		for (int j = 0; j < i; j++) {
			printf("%d", j+1);
		}
		printf("\n");
	}*/
	//4)
	for (int i = 0; i < 9; i++) {
		for (int j = i; j < 9; j++) {
			printf("%d", j + 1);
		}
		printf("\n");
	}
}