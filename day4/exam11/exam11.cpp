// exam11.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"
#include <stdio.h>

int main()
{
	int b_num, age;
	double b_avg;

	printf("���ȣ�� �Է��ϼ��� : ");
	scanf("%d", &b_num);

	printf("Ÿ���� �Է��ϼ��� : ");
	scanf("%lf", &b_avg);

	printf("���̸� �Է��ϼ��� : ");
	scanf("%d", &age);

	printf("%d�� ������ Ÿ���� %lf�̰� ���̴� %d���Դϴ�. \n", b_num, b_avg, age);
    return 0;
}

