#include <stdio.h>
int main() {
	double height, weight, std;

	printf("Ű, ü���� �Է����ּ���\n");
	scanf_s("%lf %lf", &height, &weight);

	std = (height - 100) * 0.9;

	printf("Ű : %.0lf\n", height);
	printf("ü�� : %.1lf\n", weight);
	if (std - weight >= 5) {
		printf("����� ��ü���Դϴ�.");
	}
	else if (std - weight <= -5) {
		printf("����� ��ü���Դϴ�.");
	}
	else
		printf("����� ǥ�� ü���Դϴ�.");
}