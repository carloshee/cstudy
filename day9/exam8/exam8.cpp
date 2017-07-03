// exam8.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"
#include "string.h"


int main()
{
	char *strItems = "pike,plate amor,lather grove,sword,dager";

	char nIndexTable[32];

	int nIndex = 0, num = 0;
	printf("select index : ");
	scanf("%d", &nIndex);

	for (int i = 0; i < strlen(strItems)+1; i++) {
		if (*(strItems + i) == ',') {
			nIndexTable[num++] = i;
			continue;
		}
		if (num == nIndex - 1) {
			printf("%c", *(strItems + i));
		}
	}

	printf("");

    return 0;
}

