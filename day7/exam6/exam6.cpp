// exam6.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"


int main()
{
	int nAry[10] = { 1, 2, 3, 4, 10 };
	int nAry2[5] = { 5, 6, 7, 8, 9 };
	int temp;

	//...
	//1, 2, 3, 4, 6, 0
	//1, 2, 3, 4, 6, 6
	//1, 2, 3, 4, 5, 6
	
	//int temp = nAry[4];
	//nAry[4] = 5;
	//nAry[5] = temp;

	for (int i = 0; i < sizeof(nAry2) / sizeof(nAry[0]); i++) {
		temp = nAry[i + 4];
		nAry[i + 4] = nAry2[i];
		nAry[i + 5] = temp;
	}


	for (int i = 0; i < sizeof(nAry) / sizeof(nAry[0]); i++) {
		printf("%d ", nAry[i]);
	}

    return 0;
}

