// exam5.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"
#include <string.h>

int main()
{
	char *pTest = "apple";
	char szBuf[32];

	strcpy(szBuf, pTest);

	printf(" %d \n", strcmp(szBuf, pTest));
	printf(" %d \n", strcmp(szBuf + 1, pTest));

	szBuf[1] = 'f';
	printf("%s %d \n", szBuf, strcmp(szBuf, pTest));

	TCHAR *wpTest = L"먹다버린사과";
	TCHAR wszBuf[32];

	wcscpy(wszBuf, wpTest);

	printf(" %d \n", wcscmp(wszBuf, wpTest));
	printf(" %d \n", wcscmp(L"가", L"나"));
	printf(" %d \n", wcscmp(L"파", L"라"));

    return 0;
}

