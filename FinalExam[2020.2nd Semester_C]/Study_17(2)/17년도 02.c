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
}

void change_name(struct person *Team, char*fname, int size) {
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
		printf("»õ·Î¿î ÀÌ¸§ : ");
		scanf("%s", nname);
		strcpy(Team[idx].name, nname);
	}
	else {
		printf("ÇØ´ç ÀÌ¸§ %sÀÌ Á¸ÀçÇÏÁö ¾Ê½À´Ï´Ù.", fname);
	}
}

int main() {
	struct person member[5] = {
		{.name = "±è±æµ¿", .birthday = {.year = 1990, .month = 7, .day = 5}, .score[0] = 80, .score[1] = 60, .score[2] = 75, .score[3] = 40},
		{.name = "±è¼¼¿µ", .birthday = {.year = 1994, .month = 6, .day = 20}, .score[0] = 60, .score[1] = 75, .score[2] = 60, .score[3] = 55},
		{.name = "ÀåÈï¼ö", .birthday = {.year = 1990, .month = 10, .day = 3}, .score[0] = 55, .score[1] = 60, .score[2] = 75, .score[3] = 85},
		{.name = "±è¿µÈñ", .birthday = {.year = 1995, .month = 4, .day = 30}, .score[0] = 50, .score[1] = 80, .score[2] = 90, .score[3] = 85},
		{.name = "¹ÚÁ¾¼ö", .birthday = {.year = 1991, .month = 4, .day = 5}, .score[0] = 90, .score[1] = 80, .score[2] = 85, .score[3] = 90}
	};

	output_info(member, 5);
	change_name(member, "±è¿µÈñ", 5);
	output_info(member, 5);
}