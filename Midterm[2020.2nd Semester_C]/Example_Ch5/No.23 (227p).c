#include <stdio.h>
int main() {
	int num;
	printf("피보나치 개수 입력 : ");
	scanf_s("%d", &num);
	printf("\n*** 피보나치 수열 ***\n0, 1");
	int f1 = 0, f2 = 1, f3;

	for (int i = 1; i <= num - 2; i++) {
		f3 = f1 + f2;
		printf(", %d", f3);
		f1 = f2;
		f2 = f3;
	}
	printf("입니다.");
}