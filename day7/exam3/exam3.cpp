// exam3.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"


int main()
{
	int ary[] = { 2, 8, 15, 1, 8, 10, 5, 19, 19, 3, 5, 6, 6, 2, 8, 2, 12 };
	int num, n = 0;
	printf("ã�⸦ ���ϴ� ���ڸ� �Է��ϼ���(1~20) : ");
	scanf_s("%d", &num);

	for (int i = 0; i < sizeof(ary); i++) {
		if (num == ary[i]) {
			n++;
		}
	}

	printf("���� %d�� �迭�� %d�� �ֽ��ϴ�. \n", num, n);

    return 0;
}
