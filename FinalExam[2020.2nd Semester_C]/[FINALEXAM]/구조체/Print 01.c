#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
struct game {
	char name[10];
	int R1, R2, R3;
};

int main() {
	struct game player;
	double avg;

	printf("������ �̸��� ? ");
	scanf("%s", player.name);
	printf("1, 2, 3���� ������ ? ");
	scanf("%d %d %d", &player.R1, &player.R2, &player.R3);

	avg = (double)(player.R1 + player.R2 + player.R3) / 3;
	printf("%s������ ���� ���� ��� %.1lf��\n", player.name, avg);
}