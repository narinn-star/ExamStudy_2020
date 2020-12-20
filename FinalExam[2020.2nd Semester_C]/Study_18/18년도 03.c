#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
struct date {
	int year;
	int month;
};

struct person {
	char name[10];
	int score[4];
	double avg;
	struct date birthday;
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
				else {
					printf(", %s", Team[j].name);
				}
				
			}
		}
	}

}

int main() {
	struct person Team[5] = {
		{.name = "김길동", .birthday = {.year = 1990, .month = 7}, .score[0] = 80, .score[1] = 60, .score[2] = 75, .score[3] = 40},
		{.name = "김세영", .birthday = {.year = 1994, .month = 6}, .score[0] = 60, .score[1] = 75, .score[2] = 60, .score[3] = 55},
		{.name = "장흥수", .birthday = {.year = 1990, .month = 10}, .score[0] = 55, .score[1] = 60, .score[2] = 75, .score[3] = 85},
		{.name = "김영희", .birthday = {.year = 1995, .month = 4}, .score[0] = 50, .score[1] = 80, .score[2] = 90, .score[3] = 85},
		{.name = "박종수", .birthday = {.year = 1991, .month = 4}, .score[0] = 90, .score[1] = 80, .score[2] = 85, .score[3] = 90}
	};

	printf("18년도 01번\n");
	output_info(Team, 5);
	printf("\n18년도 02번\n");
	cal_avg(Team, 5);
	printf("\n18년도 03번\n");
	list_byBirthYear(Team, 5);
	printf("\n");
}