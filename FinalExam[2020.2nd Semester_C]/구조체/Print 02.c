#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
struct rectangle {
	int width;
	int height;
	int area;
};

int main() {
	struct rectangle r1 = { .width = 3, .height = 7 };
	struct rectangle r2 = { .width = 2, .height = 5 };
	r1.area = r1.width * r1.height;
	r2.area = r2.width * r2.height;
	
	int larger;
	if (r1.area >= r2.area) {
		larger = r1.area;
	}
	else
		larger = r2.area;

	printf("더 큰 사각형의 면적은 %d입니다.", larger);
}