#include "stdafx.h"

extern void win32_Printf(HWND, TCHAR *, ...);

int addTen(int b)
{
	b += 10;
	return b;
}

void addTen2(int *b)
{
	*b += 10;
}

void addTen3(int &b)
{
	b += 10;
}

void addTen4(int *b)
{
	b += 10;
}

void testProc1(HWND hWnd)
{
	win32_Printf(hWnd, L"testproct");

	int val_a, c;
	val_a = 5;

	c = addTen(val_a);

	win32_Printf(hWnd, L"%d", c);

	addTen2(&c);

	win32_Printf(hWnd, L"%d", c);

	addTen3(c);

	win32_Printf(hWnd, L"%d", c);
}