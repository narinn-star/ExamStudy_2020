#include <stdio.h>
#include <string.h>
int main() {
	char data[80];
	printf("���ڿ��� �Է��ϼ��� : ");
	gets(data);
	printf("�Էµ� ���ڿ��� ���Ե� ���ڴ� %d�� �Դϴ�.",strlen(data));
}