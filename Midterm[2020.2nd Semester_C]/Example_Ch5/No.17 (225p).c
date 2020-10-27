#include <stdio.h>
int main() {
	int n, sum = 0;
	printf("제곱의 합을 구할 n을 입력 : ");
	scanf_s("%d", &n);
	for (int i = 1; i <= n; i++) {
		sum += i * i;
	}
	printf("1부터 %d까지의 제곱의 합은 %d입니다.", n, sum);
}