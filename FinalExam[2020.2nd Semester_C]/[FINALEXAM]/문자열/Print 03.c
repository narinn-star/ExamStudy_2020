#include <stdio.h>
#include <string.h>
int main() {
	char data[50] = { 0 }, del;
	printf("���ڿ��� �Է��ϼ��� : ");
	gets(data);
	printf("������ ���ڸ� �Է��ϼ��� : ");
	scanf_s("%c", &del, 1);
	//��� �˻�
	for (int i = 0; i < 50; i++) {
		if (data[i] == del) {
			data[i] = data[i + 1];
		}
	}
	printf("���� '%c'�� ������ ���ڿ��� %s�Դϴ�.", del, data);
}