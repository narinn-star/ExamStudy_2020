#include <stdio.h>
int main() {
	//Ű����� ���� n�� �Է¹޾� n!�� ���ϴ� ���α׷�

	int n, sum = 1;
	printf("���ڸ� �Է��ϼ��� : ");
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