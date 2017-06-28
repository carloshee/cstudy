// exam11.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"
#include <stdio.h>

int main()
{
	int b_num, age;
	double b_avg;

	printf("등번호를 입력하세요 : ");
	scanf("%d", &b_num);

	printf("타율을 입력하세요 : ");
	scanf("%lf", &b_avg);

	printf("나이를 입력하세요 : ");
	scanf("%d", &age);

	printf("%d번 선수의 타율은 %lf이고 나이는 %d살입니다. \n", b_num, b_avg, age);
    return 0;
}

