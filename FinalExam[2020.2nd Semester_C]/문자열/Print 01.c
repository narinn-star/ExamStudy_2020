#include <stdio.h>
int main() {
	char name[10], pnum[15], add[10];

	printf("�̸��� �Է����ּ���");
	scanf_s("%s", name);
	printf("��ȭ��ȣ�� �Է����ּ���");
	scanf_s("%s", pnum);
	printf("�ּҸ� �Է����ּ���");
	scanf_s("%s", add);
	printf("�̸� : %s\n��ȭ��ȣ : %s\n�ּ� : %s\n", name, pnum, add);
	printf("�� �̸��� %s�̰� ��ȭ��ȣ�� %s, ��°��� %s�Դϴ�.", name, pnum, add);
	
}