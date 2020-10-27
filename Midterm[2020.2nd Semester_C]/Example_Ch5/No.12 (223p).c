#include <stdio.h>
int main() {
	int num;

	printf("출력할 3의 배수의 개수는 : ");
	scanf_s("%d", &num);

	for (int i = 1; i <= num; i++) {
		printf("%d ", i * 3);
	}
}