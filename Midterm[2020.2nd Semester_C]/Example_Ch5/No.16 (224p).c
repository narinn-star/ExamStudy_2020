#include <stdio.h>
int main() {
	//1~n�� �� �� 1000�� ���� �ʴ� ���� ū �հ� �׋��� n�� ���ϴ� ���α׷�
	
	int sum = 0;

	int i = 0;
	while (1) {
		sum += i;
		if (sum + i >= 1000)
			break;
		i++;
	}
	printf("1���� %d������ ���� %d�Դϴ�.", i, sum);

	/*for (int i = 1; i <= num; i++) {
		sum += i;
		if (sum + i >= 1000)
			break;
	}
	printf("1���� %d������ ���� %d�Դϴ�.", num, sum);*/
}