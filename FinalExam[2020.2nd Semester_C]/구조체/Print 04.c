#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
struct person {
	char name[20];
	char gender[1];
	int age;
};
int main() {
	struct person member[3] = {
		{.name = "홍길동", .gender = "M", .age = 25},
		{.name = "이나린", .gender = "F", .age = 21},
		{.name = "강태현", .gender = "M", .age = 20}
	};

	printf("멤버 정보\n");
	for (int i = 0; i < 3; i++) {
		printf("이름 : %s, 성별 : %s, 나이 : %d\n", member[i].name, member[i].gender, member[i].age);
	}
}