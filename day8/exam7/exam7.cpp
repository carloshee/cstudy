// exam7.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"

void assign(int *test) 
{
	*test = 100;
}

void getSum(int a, int b, int *nSum)
{
	*nSum = a + b;
}

void exchange(int *c, int *m)
{
	int temp;
	temp = *c;
	*c = *m;
	*m = temp;
}

int main()
{
	int test = 0;

	assign(&test);

	printf("%d \n", test);

	getSum(5, 6, &test);
	printf("%d \n", test);

	int a = 7;
	int b = 8;
	//exchange(a, b);
	
	exchange(&a, &b);

	printf("a = %d, b = %d \n", a, b);

    return 0;
}

