// exam8.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"

void dumpBuf(int nBuf[], int nSize)
{
	for (int i = 0; i < nSize; i++) {
		printf("%d ", nBuf[i]);
	}
	printf("\n");
}

int main()
{
	int nBuf[] = {1, 2, 3, 4, 5, 6, 7, 8};
	int nBufSize = sizeof(nBuf) / sizeof(nBuf[0]);
	int num = nBufSize;

	bool bLoop = true;
	while (bLoop) {
		int nIndex, nValue;
		printf("������ ��ġ�� �Է��ϼ��� (�����÷��� 8�̻� �Է��� �ϼ���): ");
		scanf("%d", &nIndex);

		if (nIndex >= 8) {
			bLoop = false;
		}

		for (int i = nIndex; i < nBufSize; i++) {
			nBuf[i - 1] = nBuf[i];
		}
		
		nBuf[--num] = 0;

		dumpBuf(nBuf, nBufSize);
	}

	return 0;
}

