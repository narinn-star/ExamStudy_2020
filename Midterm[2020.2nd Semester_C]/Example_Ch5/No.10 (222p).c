#include <stdio.h>
int main() {
	int num;
	printf("수 입력 : ");
	scanf_s("%d", &num);
	
	int mul;
	printf("계산법(1, 2, 3) : ");
	scanf_s("%d", &mul);
	

	int result;
	switch (mul) {
	case 1: result = num;
		break;
	case 2: result = num * 2;
		break;
	case 3: result = num * 3;
		break;
	default: printf("잘못된 계산법입니다.");
		
	}
	printf("입력한 수 %d의 %d배수는 %d입니다.", num, mul, result);

}