#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
struct person {
	char name[20];
	char gender[1];
	int age;
};
int main() {
	struct person member[3] = {
		{.name = "ȫ�浿", .gender = "M", .age = 25},
		{.name = "�̳���", .gender = "F", .age = 21},
		{.name = "������", .gender = "M", .age = 20}
	};

	printf("��� ����\n");
	for (int i = 0; i < 3; i++) {
		printf("�̸� : %s, ���� : %s, ���� : %d\n", member[i].name, member[i].gender, member[i].age);
	}
}