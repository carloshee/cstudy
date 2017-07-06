#include "stdafx.h"

extern void win32_Printf(HWND, TCHAR *, ...);

int addTen(int b)
{
	b += 10;
	return b;
}

void testProc1(HWND hWnd)
{
	win32_Printf(hWnd, L"testproct");

	int a, c;
	a = 5;

	c = addTen(a);

	win32_Printf(hWnd, L"%d", c);
}