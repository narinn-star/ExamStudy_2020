#include <stdio.h>
int main() {
	double height, weight, std;

	printf("키, 체중을 입력해주세요\n");
	scanf_s("%lf %lf", &height, &weight);

	std = (height - 100) * 0.9;

	printf("키 : %.0lf\n", height);
	printf("체중 : %.1lf\n", weight);
	if (std - weight >= 5) {
		printf("당신은 저체중입니다.");
	}
	else if (std - weight <= -5) {
		printf("당신은 과체중입니다.");
	}
	else
		printf("당신은 표준 체중입니다.");
}