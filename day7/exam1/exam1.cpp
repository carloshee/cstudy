// exam1.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"


int main()
{

	int ages[4];
	int avg = 0;

	for (int i = 0; i < 4; i++) {
		printf("%d ��° ���� �Է��ϼ��� : ", i);
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

	printf("�ִ밪�� : %d \n", max);
	printf_s("�ּҰ��� : %d \n", min);

    return 0;
}

