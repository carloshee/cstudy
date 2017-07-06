#include "stdafx.h"
#include "../../engine/utils.h"

void swapString(TCHAR **str1, TCHAR **str2) 
{
	TCHAR *szTemp;
	szTemp = *str1;
	*str1 = *str2;
	*str2 = szTemp;
}

void Printf(TCHAR **str1, HWND hWnd, int nCount)
{
	for (int i = 0; i < nCount; i++) {
		win32_Printf(hWnd, L"%s", str1[i]);
	}
}

void procTest5(HWND hWnd)
{
	int val = 100;
	int *ip = &val;
	int **ipp = &ip;
	int ***ippp = &ipp;

	win32_Printf(hWnd, L"%d %d", ip, *ipp);

	win32_Printf(hWnd, L"%d %d", ip, ipp);

	win32_Printf(hWnd, L"%d %d, %d", *ippp, **ippp, ***ippp);


	TCHAR *szStr[2] = { L"�ȳ��ϼ���.", L"���� ����� �Դϴ�." };

	win32_Printf(hWnd, L"%s %s", szStr[0], szStr[1]);
	swapString(&szStr[0], &szStr[1]);

	/*TCHAR *szTemp;

	szTemp = szStr[0];
	szStr[0] = szStr[1];
	szStr[1] = szTemp;*/

	win32_Printf(hWnd, L"%s %s", szStr[0], szStr[1]);

	/*TCHAR *ptr_ary[] = {
		L"����", L"��", L"Ƽ���", L"������", L"�Ƹ�������"
	};

	int nCount = sizeof(ptr_ary) / sizeof(ptr_ary[0]);
	for (int i = 0; i < nCount; i++) {
		win32_Printf(hWnd, L"%s", ptr_ary[i]);
	}*/

	TCHAR *ptr_ary[] = {
		L"����", L"��", L"Ƽ���", L"������", L"�Ƹ�������"
	};

	int nCount = sizeof(ptr_ary) / sizeof(ptr_ary[0]);

	Printf(ptr_ary, hWnd, nCount);
}