#include <stdio.h>
int main() {
	int a, b, c, result;
	printf("�� ���� ������ �Է��Ͻÿ� : ");
	scanf_s("%d %d", &a, &b);
	
	while (b != 0) {
		c = a % b;
		a = b;
		b = c;
	}
	printf("�ִ� ������� %d�Դϴ�.", a);
}