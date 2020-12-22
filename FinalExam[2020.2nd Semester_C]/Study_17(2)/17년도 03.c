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

void output_info(struct person* Team, int size) {
	for (int i = 0; i < size; i++) {
		int sum = 0;
		printf("%s %d-%d-%d ", Team[i].name, Team[i].birthday.year, Team[i].birthday.month, Team[i].birthday.day);
		for (int j = 0; j < 4; j++) {
			printf("%d ", Team[i].score[j]);
			sum += Team[i].score[j];
		}
		printf("%d %.2lf\n", sum, (double)sum / 4);
	}
	printf("\n");
}

void change_name(struct person* Team, char* fname, int size) {
	int idx;
	int isname = 0;
	char nname[10];
	for (int i = 0; i < size; i++) {
		if (strcmp(Team[i].name, fname) == 0) {
			isname = 1;
			idx = i;
		}
	}
	if (isname == 1) {
		printf("새로운 이름 : ");
		scanf("%s", nname);
		strcpy(Team[idx].name, nname);
	}
	else {
		printf("해당 이름 %s이 존재하지 않습니다.", fname);
	}
	printf("\n");
}

void list_birthday_byMonth(struct person* Team, int size) {
	int idx;
	for (int i = 1; i < 13; i++) {
		int count = 0;
		for (int j = 0; j < size; j++) {
			if (i == Team[j].birthday.month) {
				count++;
				idx = i;
				if (count == 1) {
					printf("\n%d월\t생일 : %s", idx, Team[j].name);
				}
				else {
					printf(", %s", Team[j].name);
				}
			}
		}
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
	change_name(member, "김영희", 5);
	output_info(member, 5);
	list_birthday_byMonth(member, 5);
}