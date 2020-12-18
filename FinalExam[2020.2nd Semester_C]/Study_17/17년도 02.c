#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
struct date {
	int year;
	int month;
	int day;
};

struct person {
	char name[10];
	int score[4];
	struct date birthday;
};

output_info(struct person member[], int size) {
	for (int i = 0; i < size; i++) {
		int sum = 0;
		printf("%s %d-%d-%d ", member[i].name, member[i].birthday.year, member[i].birthday.month, member[i].birthday.day);
		for (int j = 0; j < 4; j++) {
			printf("%d ", member[i].score[j]);
			sum += member[i].score[j];
		}
		printf("%d %.2lf\n", sum, (double)sum / 4);
	}
}

change_name(struct person member[], char* sname, int size) {
	int isname = 0;
	int idx;
	char fname[10];
	for (int i = 0; i < size; i++) {
		if (strcmp(member[i].name, sname) == 0) {
			isname = 1;
			idx = i;
		}
	}
	if (isname == 1) {
		printf("새로운 이름을 입력해주세요 >> ");
		scanf("%s", fname);
		strcpy(member[idx].name, fname);
	}
	else {
		printf("해당 이름 %s이 존재하지 않습니다.", sname);
	}
}

int main() {
	struct person member[5] = {
		{.name = "김길동", .birthday = {.year = 1990, .month = 7, .day = 5}, .score[0] = 80, .score[1] = 60, .score[2] = 75, .score[3] = 40},
		{.name = "김세영", .birthday = {.year = 1994, .month = 6, .day = 20}, .score[0] = 60, .score[1] = 75, .score[2] = 60, .score[3] = 55},
		{.name = "장흥수", .birthday = {.year = 1990, .month = 10, .day = 3}, .score[0] = 55, .score[1] = 60, .score[2] = 75, .score[3] = 85},
		{.name = "김영희", .birthday = {.year = 1995, .month = 4, .day = 30}, .score[0] = 50, .score[1] = 80, .score[2] = 90, .score[3] = 85},
		{.name = "박종수", .birthday = {.year = 1991, .month = 4, .day = 5}, .score[0] = 90, .score[1] = 80, .score[2] = 85, .score[3] = 90}
	};

	output_info(member, 5);
	printf("\n");
	change_name(member, "김길동", 5);
	output_info(member, 5);
}