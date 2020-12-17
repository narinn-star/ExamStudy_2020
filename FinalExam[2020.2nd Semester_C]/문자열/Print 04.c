#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
int main() {
	char data1[10], data2[10], data3[10];
	printf("data1 : ");
	scanf("%s", data1);
	printf("data2 : ");
	scanf("%s", data2);
	strcpy(data3, data1);
	strcat(data3, data2);
	puts(data3);
}