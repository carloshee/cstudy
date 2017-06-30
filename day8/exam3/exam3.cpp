// exam3.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"
#include <stdlib.h>

int main()
{
	char szInputBuf[] = "23,45,67,100,45";
	char szTemp[16]; //토큰 저장 버퍼
	int nTempIndex = 0;
	int szInputBufSize = sizeof(szInputBuf) / sizeof(szInputBuf[0]);

	//, 기준으로 끊어내기
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

