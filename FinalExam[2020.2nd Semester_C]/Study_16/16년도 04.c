#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
struct student {
	int studentNum;
	char name[10];
	int age;
	char address[10];
};

void PrintCities(struct student* Aclass, int size) {
	char** AArray = { 0 };
	int count = 0;
	for (int i = 0; i < size; i++) {
		int existCheck = 0;
		if (count == 0) {
			AArray = (char**)malloc(sizeof(char*) * ++count);
			AArray[0] = (char*)malloc(sizeof(char) * 10);
			strcpy(AArray[0], Aclass[i].address);
		}
		else {
			for (int j = 0; j < count; j++) {
				if (strcmp(AArray[j], Aclass[i].address) == 0) {
					existCheck++;
				}
			}
			if (existCheck == 0) {
				char** tmpArr = (char**)malloc(sizeof(char*) * count);
				for (int k = 0; k < count; k++) {
					tmpArr[k] = (char*)malloc(sizeof(char) * 10);
					strcpy(tmpArr[k], AArray[k]);
				}
				AArray = (char**)malloc(sizeof(char*) * ++count);
				for (int m = 0; m < count; m++) {
					AArray[m] = (char*)malloc(sizeof(char) * 10);
					if (m !=count - 1)
					strcpy(AArray[m], tmpArr[m]);
				}
				strcpy(AArray[count - 1], Aclass[i].address);
			}
		}
	}
	printf("Print List : \n");
	for (int i = 0; i < count; i++) {
		printf("\t%s\n", AArray[i]);
	}
	printf("\n");
}

int main() {
	struct student Aclass[5] = {
		{.studentNum = 2010123, .name = "��浿", .age = 20, .address = "�λ��"},
		{.studentNum = 2011134, .name = "���μ�", .age = 19, .address = "����"},
		{.studentNum = 2009235, .name = "�ڼ���", .age = 21, .address = "�λ��"},
		{.studentNum = 2010234, .name = "�ڼ�ȫ", .age = 21, .address = "�λ��"},
		{.studentNum = 2006525, .name = "�����", .age = 24, .address = "â����"},
	};

	PrintCities(Aclass, 5);
}