#include <stdio.h>
int main() {
	int num;
	double prime = 1;

	printf("양의 정수 n : ");
	scanf_s("%d", &num);

	
	for (int i = 2; i <= (num - 1); i++) {
		if (num % i == 0) {
			prime = 0;
			break;
		}
	}
	if (prime == 1)
		printf(">> %d는(은) 소수입니다.", num);
	else
		printf(">> %d는(은) 소수가 아닙니다.", num);
}