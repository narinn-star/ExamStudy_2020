#include <stdio.h>
int main() {
	int month;
	printf("�� �Է� : ");
	scanf_s("%d", &month);

	switch (month) {
	case 1: 
	case 2:
	case 3: printf(">> 1��б��Դϴ�.");
		break;
	case 4:
	case 5:
	case 6: printf(">> 2��б��Դϴ�.");
		break;
	case 7:
	case 8:
	case 9: printf(">> 3��б��Դϴ�.");
		break;
	case 10:
	case 11:
	case 12: printf(">> 4��б��Դϴ�.");
		break;
	}
}