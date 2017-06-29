// exam5.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"


int main()
{
	int a[5] = { 1, 2, 3, 4, 5 };
	int aSize = sizeof(a) / sizeof(a[0]);
	int temp;

	printf("처음 배열에 저장된 값 : ");

	for (int i = 0; i < aSize; i++) {
		printf("%d ", a[i]);
	}
	
	for (int i = 0; i < aSize / 2; i++) {
		temp = a[i];
		a[i] = a[aSize - i - 1];
		a[aSize - i - 1] = temp;
	}

	printf("\n바뀐 배열에 저장된 값 : ");

	for (int i = 0; i < aSize; i++) {
		printf("%d ", a[i]);
	}

	printf("\n");

    return 0;
}

