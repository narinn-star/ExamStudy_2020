#include <stdio.h>
int main() {
	char ch;

	scanf_s("%c", &ch);
	printf("���� �Է� : %c\n", ch);

	if (ch >= '0' && ch <= '9') {
		printf("�����Դϴ�.");
	}
	else if (ch >= 'a' && ch <= 'z') {
	printf("���ĺ� �ҹ����Դϴ�.");
	}
	else if (ch >= 'A' && ch <= 'Z') {
		printf("���ĺ� �빮���Դϴ�.");
	}
	else
		printf("���ĺ���, ���ڵ� �ƴմϴ�.");
}