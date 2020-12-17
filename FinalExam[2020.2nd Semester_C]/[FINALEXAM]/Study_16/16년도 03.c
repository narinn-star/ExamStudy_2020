#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
void init(char** flowers, int size) {
		char temp[100];
	for (int i = 0; i < size; i++) {
		scanf("%s", temp);
		flowers[i] = (char*)malloc(sizeof(char) * strlen(temp));
		strcpy(flowers[i], temp);
	}
}

void prn(char** flowers, int size) {
	for (int i = 0; i < size; i++) {
		printf("%s\t", flowers[i]);
	}
}

int main() {
	char* flower[5] = { "lily", "cosmos", "sunflower", "rose", "lavender" };
	
	init(flower, 5);
	prn(flower, 5);
}