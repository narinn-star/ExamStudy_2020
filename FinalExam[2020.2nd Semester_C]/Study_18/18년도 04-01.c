#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
struct date {
	int year;
	int month;
};

struct address {
	char city[10];
	char gu[10];
	char dong[10];
};

struct person {
	char name[10];
	int score[4];
	double avg;
	struct date birthday;
	struct address homeAdd;
};

void output_info(struct person Team[], int size) {
	for (int i = 0; i < size; i++) {
		printf("%s ", Team[i].name);
		for (int j = 0; j < 4; j++) {
			printf("%d/", Team[i].score[j]);
		}
		printf("\b-%.1lf\n", Team[i].avg);
	}
}

void cal_avg(struct person Team[], int size) {
	for (int i = 0; i < size; i++) {
		int sum = 0;
		printf("%s ", Team[i].name);
		for (int j = 0; j < 4; j++) {
			printf("%d/", Team[i].score[j]);
		}
		for (int m = 0; m < 4; m++) {
			sum += Team[i].score[m];
		}

		printf("\b-%.2lf\n", (double)sum / 4);
	}
}

void list_byBirthYear(struct person Team[], int size) {
	int idx;
	for (int i = 0; i < 2000; i++) {
		int count = 0;
		for (int j = 0; j < size; j++) {
			if (i == Team[j].birthday.year) {
				count++;
				if (count == 1) {
					printf("\n%d년\t생일 : %s", Team[j].birthday.year, Team[j].name);
					idx = j;

				}
				else
					printf(", %s", Team[j].name);
			}
		}
	}
	printf("\n");
}

void output_info2(struct person Team[], int size) {
	for (int i = 0; i < size; i++) {
		printf("%s, %d, %d, ", Team[i].name, Team[i].birthday.year, Team[i].birthday.month);
		for (int j = 0; j < 4; j++) {
			printf("%d,", Team[i].score[j]);
		}
		printf("%s, %s, %s,\n", Team[i].homeAdd.city, Team[i].homeAdd.gu, Team[i].homeAdd.dong);
	}
}

void list_byCity(struct person Team[], char* city) {
	int idx[5];
	int iscity = 0;
	int count = 0;
	
	for (int i = 0; i < 5; i++) {
		if (strcmp(Team[i].homeAdd.city, city) == 0) {
			iscity = 1;
			idx[i] = i;
			count++;
		}
	}
	if (iscity == 1) {
		printf("%s에 거주하는 학생은 %d명입니다.\n", city, count);
		for (int i = 0; i < 5; i++) {
			int sum = 0;
			if (i == idx[i]) {
				printf("%d. %s %d-%d ", i + 1, Team[i].name, Team[i].birthday.year, Team[i].birthday.month);
				for (int j = 0; j < 4; j++) {
					printf("%d ", Team[i].score[j]);
				}
				for (int m = 0; m < 4; m++) {
					sum += Team[i].score[m];
				}
				printf("%d %.2lf ", sum, (double)sum / 4);
				printf("%s-%s-%s\n", Team[i].homeAdd.city, Team[i].homeAdd.gu, Team[i].homeAdd.dong);
			}
		}
	}
}

int main() {
	struct person Team[5] = {
		{.name = "김길동", .birthday = {.year = 1990, .month = 7},
		.score[0] = 80, .score[1] = 60, .score[2] = 75, .score[3] = 40,
		.homeAdd = {.city = "부산시", .gu = "동래구", .dong = "사직동"}},

		{.name = "김세영", .birthday = {.year = 1994, .month = 6},
		.score[0] = 60, .score[1] = 75, .score[2] = 60, .score[3] = 55,
		.homeAdd = {.city = "창원시", .gu = "남구", .dong = "용호동"}},

		{.name = "장흥수", .birthday = {.year = 1990, .month = 10},
		.score[0] = 55, .score[1] = 60, .score[2] = 75, .score[3] = 85,
		.homeAdd = {.city = "부산시", .gu = "북구", .dong = "만덕동"}},

		{.name = "김영희", .birthday = {.year = 1995, .month = 4},
		.score[0] = 50, .score[1] = 80, .score[2] = 90, .score[3] = 85,
		.homeAdd = {.city = "부산시", .gu = "동래구", .dong = "안락동"}},

		{.name = "박종수", .birthday = {.year = 1991, .month = 4},
		.score[0] = 90, .score[1] = 80, .score[2] = 85, .score[3] = 90,
		.homeAdd = {.city = "울산시", .gu = "남구", .dong = "호계동"}}
	};

	printf("18년도 01번\n");
	output_info(Team, 5);
	printf("\n18년도 02번\n");
	cal_avg(Team, 5);
	printf("\n18년도 03번\n");
	list_byBirthYear(Team, 5);
	printf("\n18년도 04번\n");
	output_info2(Team, 5);
	printf("\n18년도 04-01번\n");
	list_byCity(Team, "부산시");
}