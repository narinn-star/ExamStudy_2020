#include <stdio.h>
int main() {
	//키보드로 정수 n을 입력받아 n!을 구하는 프로그램

	int n, sum = 1;
	printf("숫자를 입력하세요 : ");
	scanf_s("%d", &n);

	if (n == 0)
		printf("%d! = 1", n);
	else {
		for (int i = 1; i <= n; i++) {
			sum *= i;
		}
		printf("%d! = %d", n, sum);
	}
}