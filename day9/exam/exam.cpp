// exam.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"
void getBuble(int *gp, int nSize)
{
	int temp = 0;

	for (int i = 0; i < nSize - 1; i++) {
		for (int j = 0; j < (nSize - i - 1); j++) {
			if (gp[j] > gp[j + 1])
			{
				temp = gp[j];
				gp[j] = gp[j + 1];
				gp[j + 1] = temp;
			}
		}
	}

	for (int i = 0;i < nSize; i++) {
		printf_s("%d ", *(gp + i));
	}
}

int main()
{
	int num[6] = { 9, 3, 13, 42, 5, 4};
	int numSize = sizeof(num) / sizeof(num[0]);

	getBuble(num, numSize);

    return 0;
}

