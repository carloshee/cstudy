// exam3.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"
#include <stdlib.h>

int main()
{
	char szInputBuf[] = "23,45,67,100,45";
	char szTemp[16]; //��ū ���� ����
	int nTempIndex = 0;
	int szInputBufSize = sizeof(szInputBuf) / sizeof(szInputBuf[0]);

	//, �������� �����
	int nSum = 0;
	for (int i = 0; i < szInputBufSize; i++) {
		if (szInputBuf[i] == ',' || i == szInputBufSize - 1) {
			//break;
			szTemp[nTempIndex] = NULL;
			printf("%s \n", szTemp);
			int nNum = atoi(szTemp);
			nSum += nNum;
			nTempIndex = 0;
		}
		else
			szTemp[nTempIndex++] = szInputBuf[i];
	}
	printf("sum %d", nSum);

    return 0;
}

