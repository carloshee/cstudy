// exam8.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"


int main()
{
	int nNum = 0x11223344;
	unsigned char *pTest;

	pTest = (unsigned char *)&nNum;

	for (int i = 0; i < 4; i++) {
		printf("%x\n", *(pTest + i));
	}

	nNum = 0;
	//nNum : 8
	*pTest = 8;

	printf("nNum : %x \n", nNum);

    return 0;
}

