// exam7.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"
#include <string.h>

int main()
{
	char szBuf[64];
	gets_s(szBuf, 64);
	puts(szBuf);

	char c;
	c = getchar();
	putchar(c);

	printf("\n");

	char szTemp[64] = "apple[send]tree";

	int f = 0;

	for (int i = 0; i < sizeof(szTemp) / sizeof(szTemp[0]); i++) {
		if (szTemp[i] == '[') {
			f = 1;
		}
		else if (szTemp[i] == ']') {
			f = 0;
		}	
		else if (f == 0) {
			printf("%c", szTemp[i]);
		}
	}

	strcpy(szTemp + 5, szTemp + 11);

	printf("%s \n", szTemp);

    return 0;
}

