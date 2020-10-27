#include <stdio.h>
int main() {
	int a, b, c, result;
	printf("두 개의 정수를 입력하시오 : ");
	scanf_s("%d %d", &a, &b);
	
	while (b != 0) {
		c = a % b;
		a = b;
		b = c;
	}
	printf("최대 공약수는 %d입니다.", a);
}