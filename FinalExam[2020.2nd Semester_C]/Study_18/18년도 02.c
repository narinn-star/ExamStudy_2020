#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
struct person {
	char name[10];
	int score[4];
	double avg;
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

int main() {
	struct person Team[5] = {
		{.name = "±è±æµ¿", .score[0] = 80, .score[1] = 60, .score[2] = 75, .score[3] = 40},
		{.name = "±è¼¼¿µ", .score[0] = 60, .score[1] = 75, .score[2] = 60, .score[3] = 55},
		{.name = "ÀåÈï¼ö", .score[0] = 55, .score[1] = 60, .score[2] = 75, .score[3] = 85},
		{.name = "±è¿µÈñ", .score[0] = 50, .score[1] = 80, .score[2] = 90, .score[3] = 85},
		{.name = "¹ÚÁ¾¼ö", .score[0] = 90, .score[1] = 80, .score[2] = 85, .score[3] = 90}
	};

	output_info(Team, 5);
	printf("\n");
	cal_avg(Team, 5);
}