#include "stdafx.h"
#include "../../engine/utils.h"

void procTest6(HWND hWnd) 
{
	int a = 1;
	int ary[5];
	int *ptr = &a;

	win32_Printf(hWnd, L"%u", ary);
	win32_Printf(hWnd, L"%u", &ary);

	win32_Printf(hWnd, L"%u", ary+1);
	win32_Printf(hWnd, L"%u", &ary+1); // 배열은 증가시키면 배열 전체의 값에 더한게 되어 20이 추가됨... 대략 이런 설명

	win32_Printf(hWnd, L"%u", ptr);
	win32_Printf(hWnd, L"%u", &ptr);

	win32_Printf(hWnd, L"%u", ptr+1);
	win32_Printf(hWnd, L"%u", &ptr+1); // 포인터는 4바이트 증가됨
}