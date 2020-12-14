#include <stdio.h>
#include <string.h>
int main() {
	char data[50] = { 0 }, del;
	printf("문자열을 입력하세요 : ");
	gets(data);
	printf("삭제할 문자를 입력하세요 : ");
	scanf_s("%c", &del, 1);
	//모두 검사
	for (int i = 0; i < 50; i++) {
		if (data[i] == del) {
			for (int j = i; j < strlen(data); j++) {
				data[j] = data[j + 1];
			}
		}
	}
	printf("문자 '%c'가 삭제된 문자열은 %s입니다.", del, data);
}