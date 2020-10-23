#include <stdio.h>
int main(){
	int n;
	scanf_s("%d", &n);

	//나누는 방법
	/*for (int i = 1; i <= n; i++){
		for (int j = i; j < n; j++){
			printf(" ");
		}
		for (int k = 1; k <= i; k++){
			printf("*");
		}
		for (int l = 1; l < i; l++){
			printf("*");
		}
		printf("\n");
	}*/

	//공식 이용 방법
	for (int i = 1; i <= n; i++){
		for (int k = i; k < n; k++){
			printf(" ");
		}
		for (int j = 1; j <= 2 * i - 1; j++){
			printf("*");
		}
		printf("\n");
	}
}