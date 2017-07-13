// exam8.cpp : 콘솔 응용 프로그램에 대한 진입점을 정의합니다.
//

#include "stdafx.h"

union Student 
{
	char m_ary[4];
	int m_nNum;
};

int main()
{
	Student s1 = { 'a', 'b', 'c', 0x00 };

	printf("%s \n", s1.m_ary);
	printf("%x \n", s1.m_nNum);

    return 0;
}

