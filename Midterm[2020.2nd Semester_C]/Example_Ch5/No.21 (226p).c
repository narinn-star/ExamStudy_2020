#include <stdio.h>
int main() {
	int a, b ;
	printf("�� ���� ���� �Է� : ");
	scanf_s("%d %d", &a, &b);

	printf("%d�� ��������� %d�� ����� �ƴ� ��\n", a, b);
	for (int i = 1; i <= 100; i++) {
		if (i % a == 0 && (i % b) != 0) {
			printf("%d ", i);
		}
	}
}