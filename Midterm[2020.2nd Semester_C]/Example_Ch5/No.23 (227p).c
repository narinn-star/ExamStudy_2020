#include <stdio.h>
int main() {
	int num;
	printf("�Ǻ���ġ ���� �Է� : ");
	scanf_s("%d", &num);
	printf("\n*** �Ǻ���ġ ���� ***\n0, 1");
	int f1 = 0, f2 = 1, f3;

	for (int i = 1; i <= num - 2; i++) {
		f3 = f1 + f2;
		printf(", %d", f3);
		f1 = f2;
		f2 = f3;
	}
	printf("�Դϴ�.");
}