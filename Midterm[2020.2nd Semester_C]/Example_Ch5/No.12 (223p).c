#include <stdio.h>
int main() {
	int num;

	printf("����� 3�� ����� ������ : ");
	scanf_s("%d", &num);

	for (int i = 1; i <= num; i++) {
		printf("%d ", i * 3);
	}
}