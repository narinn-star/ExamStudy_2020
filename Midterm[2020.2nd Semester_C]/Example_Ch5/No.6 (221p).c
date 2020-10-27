#include <stdio.h>
int main() {
	char ch;

	scanf_s("%c", &ch);
	printf("문자 입력 : %c\n", ch);

	if (ch >= '0' && ch <= '9') {
		printf("숫자입니다.");
	}
	else if (ch >= 'a' && ch <= 'z') {
	printf("알파벳 소문자입니다.");
	}
	else if (ch >= 'A' && ch <= 'Z') {
		printf("알파벳 대문자입니다.");
	}
	else
		printf("알파벳도, 숫자도 아닙니다.");
}