#include <stdio.h>
int main() {
	int num;
	printf("�� �Է� : ");
	scanf_s("%d", &num);
	
	int mul;
	printf("����(1, 2, 3) : ");
	scanf_s("%d", &mul);
	

	int result;
	switch (mul) {
	case 1: result = num;
		break;
	case 2: result = num * 2;
		break;
	case 3: result = num * 3;
		break;
	default: printf("�߸��� �����Դϴ�.");
		
	}
	printf("�Է��� �� %d�� %d����� %d�Դϴ�.", num, mul, result);

}