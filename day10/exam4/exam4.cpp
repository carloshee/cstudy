// exam4.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"
#include <string.h>

int main()
{
	//문자열 복사
	char *pTest = "apple";
	char szBuf[64];

	strcpy(szBuf, pTest);
	printf("%s \n", szBuf);

	strcpy(szBuf, (pTest+1));
	printf("%s \n", szBuf);

	//유니코드 버전
	TCHAR *pwTest = L"먹다버린사과";
	TCHAR szwBuf[64];

	wcscpy(szwBuf, pwTest);
	wcscpy(szwBuf, pwTest+4);

	printf("%d \n", strlen(pTest));

    return 0;
}

