#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
struct student {
	char name[10];
	int score[4];
	int total;
};

void compute(struct student* Aclass, int size) {
	for (int i = 0; i < size; i++) {
		for (int j = 0; j < 4; j++) {
			Aclass[i].total += Aclass[i].score[j];
		}
	}
}

void list(struct student* Aclass, int size) {
	for (int i = 0; i < size; i++) {
		printf("%s ", Aclass[i].name);
		for (int j = 0; j < 4; j++) {
			printf("%d ", Aclass[i].score[j]);
		}
		printf("%d\n", Aclass[i].total);
	}
}

void change_name(struct student* Aclass, char* fname, char* nname, int size) {
	printf("���� �̸� : %s\n", fname);
	printf("�ٲ� �̸� : %s\n", nname);
	int isname = 0;
	int idx;
	for (int i = 0; i < size; i++) {
		if (strcmp(Aclass[i].name, fname) == 0) {
			isname = 1;
			idx = i;
		}
	}
	if (isname) {
		strcpy(Aclass[idx].name, nname);
	}
	else {
		printf("ã�� �̸� %s�� �������� �ʽ��ϴ�.", fname);
	}
}

int main() {
	struct student Aclass[5] = {
		{.name = "�輼��", .score[0] = 60, .score[1] = 75, .score[2] = 60, .score[3] = 80},
		{.name = "��浿", .score[0] = 80, .score[1] = 60, .score[2] = 75, .score[3] = 85},
		{.name = "�����", .score[0] = 55, .score[1] = 60, .score[2] = 75, .score[3] = 70},
		{.name = "�迵��", .score[0] = 50, .score[1] = 80, .score[2] = 90, .score[3] = 85},
		{.name = "������", .score[0] = 90, .score[1] = 80, .score[2] = 85, .score[3] = 90}
	};
	int size = (sizeof(Aclass) / sizeof(struct student));
	compute(Aclass, size);
	list(Aclass, size);
	printf("\n");
	change_name(Aclass, "�迵��", "�̳���", size);
	list(Aclass, size);
}