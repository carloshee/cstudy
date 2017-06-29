// exam3.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"


int main()
{
	int ary[] = { 2, 8, 15, 1, 8, 10, 5, 19, 19, 3, 5, 6, 6, 2, 8, 2, 12 };
	int num, n = 0;
	printf("찾기를 원하는 숫자를 입력하세요(1~20) : ");
	scanf_s("%d", &num);

	for (int i = 0; i < sizeof(ary); i++) {
		if (num == ary[i]) {
			n++;
		}
	}

	printf("숫자 %d는 배열에 %d개 있습니다. \n", num, n);

    return 0;
}

