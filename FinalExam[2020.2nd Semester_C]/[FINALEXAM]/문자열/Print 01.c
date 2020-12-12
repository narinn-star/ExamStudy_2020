#include <stdio.h>
int main() {
	char name[10], pnum[15], add[10];

	printf("이름을 입력해주세요");
	scanf_s("%s", name);
	printf("전화번호를 입력해주세요");
	scanf_s("%s", pnum);
	printf("주소를 입력해주세요");
	scanf_s("%s", add);
	printf("이름 : %s\n전화번호 : %s\n주소 : %s\n", name, pnum, add);
	printf("내 이름은 %s이고 전화번호는 %s, 사는곳은 %s입니다.", name, pnum, add);
	
}