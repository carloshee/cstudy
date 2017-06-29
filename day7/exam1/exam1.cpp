// exam1.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"


int main()
{

	int ages[4];
	int avg = 0;

	for (int i = 0; i < 4; i++) {
		printf("%d 번째 값을 입력하세요 : ", i);
		scanf_s("%d", &ages[i]);
	}

	printf("%d", avg);

	int max = 0;
	for (int i = 0; i < 5; i++) {
		if (max < ages[i]) {
			max = ages[i];
		}
	}

	int min = 999;
	for (int i = 0; i < 5; i++) {
		if (min > ages[i]) {
			min = ages[i];
		}
	}

	printf("최대값은 : %d \n", max);
	printf_s("최소값은 : %d \n", min);

    return 0;
}

