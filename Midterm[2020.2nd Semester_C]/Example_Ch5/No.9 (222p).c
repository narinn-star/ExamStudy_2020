#include <stdio.h>
int main() {
	int birth;
	printf("�¾ �ظ� �Է��ϼ��� : ");
	scanf_s("%d", &birth);

	int animal = birth % 12;

	switch (animal) {
	case 0: printf(">> ����� �����̶��Դϴ�.");
		break;
	case 1: printf(">> ����� �߶��Դϴ�.");
		break;
	case 2: printf(">> ����� �����Դϴ�.");
		break;
	case 3: printf(">> ����� �������Դϴ�.");
		break;
	case 4: printf(">> ����� ����Դϴ�.");
		break;
	case 5: printf(">> ����� �Ҷ��Դϴ�.");
		break;
	case 6: printf(">> ����� �����Դϴ�.");
		break;
	case 7: printf(">> ����� �䳢���Դϴ�.");
		break;
	case 8: printf(">> ����� ����Դϴ�.");
		break;
	case 9: printf(">> ����� ����Դϴ�.");
		break;
	case 10: printf(">> ����� �����Դϴ�.");
		break;
	case 11: printf(">> ����� ����Դϴ�.");
		break;
	}
}