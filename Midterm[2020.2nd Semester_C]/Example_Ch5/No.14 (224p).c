#include <stdio.h>
int main() {
	char unit = "";
	double num;
	printf("�Է� ������ cm�̸� 'c'�� 'C'��, inch�̸� 'i'�� 'I'�� �Է��ϼ���.\n");
	printf("�Է� ���� : ");
	scanf_s("%c", &unit);
	
	printf("�Է� �� : ");
	scanf_s("%lf", &num);
	printf("\n");

	if (unit == 'c' || unit == 'C') {
		printf("�Է��� %.2lfcm�� %.2lfinch�Դϴ�.", num, num / 2.54);
	}
	else if (unit == 'i' || unit == 'I') {
		printf("�Է��� %.2lfinch�� %.2lfcm�Դϴ�.", num, num * 2.54);
	}
	else
		printf("�߸��� �Է� ���� �Դϴ�.");
}