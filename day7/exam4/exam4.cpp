// exam4.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"

int main()
{
	int ary[] = { 2, 8, 15, 1, 8, 10, 5, 19, 19, 3, 5, 6, 6, 2, 8, 2, 12 };
	int count[20] = { 0 };

	for (int i = 0; i < sizeof(count) / sizeof(ary[0]); i++) {
		for (int j = 0; j < sizeof(ary) / sizeof(ary[0]); j++) {
			if (i + 1 == ary[j]) {
				count[i]++;
			}
		}
		printf("%d - %d�� \n", i + 1, count[i]);
	}

    return 0;
}

