#include <stdio.h>
int main() {
	int num;
	double prime = 1;

	printf("���� ���� n : ");
	scanf_s("%d", &num);

	
	for (int i = 2; i <= (num - 1); i++) {
		if (num % i == 0) {
			prime = 0;
			break;
		}
	}
	if (prime == 1)
		printf(">> %d��(��) �Ҽ��Դϴ�.", num);
	else
		printf(">> %d��(��) �Ҽ��� �ƴմϴ�.", num);
}