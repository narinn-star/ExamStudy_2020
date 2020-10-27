#include <stdio.h>
int main() {
	//1~n의 합 중 1000을 넘지 않는 가장 큰 합과 그떄의 n을 구하는 프로그램
	
	int sum = 0;

	int i = 0;
	while (1) {
		sum += i;
		if (sum + i >= 1000)
			break;
		i++;
	}
	printf("1부터 %d까지의 합이 %d입니다.", i, sum);

	/*for (int i = 1; i <= num; i++) {
		sum += i;
		if (sum + i >= 1000)
			break;
	}
	printf("1부터 %d까지의 합이 %d입니다.", num, sum);*/
}