#include <stdio.h>
int main() {
	int n, sum = 0;
	printf("������ ���� ���� n�� �Է� : ");
	scanf_s("%d", &n);
	for (int i = 1; i <= n; i++) {
		sum += i * i;
	}
	printf("1���� %d������ ������ ���� %d�Դϴ�.", n, sum);
}