// exam9.cpp : �ܼ� ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"

enum season { spring, summer, fall, winter };

typedef int myint;

/*
typedef struct {
	int a;
	int b;
} _MyStruct;
*/

struct _MyStruct {
	int a;
	int b;
};

int main()
{
	season ss;
	ss = spring;
	int test = fall;

	printf("%d \n", ss);
	printf("%d \n", test+3);

	myint a = 100;
	printf("%d \n", a);

    return 0;
}

