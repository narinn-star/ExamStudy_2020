#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
void init(char **Flowers, int size) {
	char temp[100];

	for (int i = 0; i < size; i++) {
		scanf("%s", temp);
		Flowers[i] = (char*)malloc(sizeof(char) * strlen(temp));
		strcpy(Flowers[i], temp);
	}
}

void prn(char **Flowers, int size) {
	for (int i = 0; i < size; i++) {
		printf("%s\t", Flowers[i]);
	}
}

int main() {
	char* flowers[5] = { "lily", "cosmos", "sunflower", "rose", "lavender" };
	
	init(flowers, 5);
	prn(flowers, 5);
}