// exam5.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"


int main()
{
	int a[5] = { 1, 2, 3, 4, 5 };
	int aSize = sizeof(a) / sizeof(a[0]);
	int temp;

	printf("ó�� �迭�� ����� �� : ");

	for (int i = 0; i < aSize; i++) {
		printf("%d ", a[i]);
	}
	
	for (int i = 0; i < aSize / 2; i++) {
		temp = a[i];
		a[i] = a[aSize - i - 1];
		a[aSize - i - 1] = temp;
	}

	printf("\n�ٲ� �迭�� ����� �� : ");

	for (int i = 0; i < aSize; i++) {
		printf("%d ", a[i]);
	}

	printf("\n");

    return 0;
}

