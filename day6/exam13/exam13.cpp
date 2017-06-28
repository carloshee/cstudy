// exam11.cpp : ���� ���α׷��� ���� �������� �����մϴ�.
//

#include "stdafx.h"
#include "exam13.h"

#define MAX_LOADSTRING 100

#include <Windows.h>
#include <ObjIdl.h>
#include <gdiplus.h>
using namespace Gdiplus;
#pragma comment(lib,"Gdiplus.lib")

// ���� ����:
HINSTANCE hInst;                                // ���� �ν��Ͻ��Դϴ�.
WCHAR szTitle[MAX_LOADSTRING];                  // ���� ǥ���� �ؽ�Ʈ�Դϴ�.
WCHAR szWindowClass[MAX_LOADSTRING];            // �⺻ â Ŭ���� �̸��Դϴ�.

												// �� �ڵ� ��⿡ ��� �ִ� �Լ��� ������ �����Դϴ�.
ATOM                MyRegisterClass(HINSTANCE hInstance);
BOOL                InitInstance(HINSTANCE, int);
LRESULT CALLBACK    WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK    About(HWND, UINT, WPARAM, LPARAM);

int g_nHeroPosX = 100;
int g_nHeroPosY = 100;

int g_nGameLoopFSM = 1; // 0�̸� �����غ�, 1 ������

//int g_PosX = 0, g_PosY = 0;

void GDIPLUS_Loop(MSG &msg)
{
	GdiplusStartupInput gdiplusStartupInput;
	ULONG_PTR gdiplusToken;
	GdiplusStartup(&gdiplusToken, &gdiplusStartupInput, NULL);

	{
		bool bQuit = false;
		SolidBrush brushBlack(Color(0, 0, 0));
		SolidBrush brushRed(Color(255, 0, 0));

		Rect screenRect(0, 0, 500, 500);
		Bitmap bmpMem(screenRect.Width, screenRect.Height);
		Graphics *backScreen = Graphics::FromImage(&bmpMem);
		double dbAngle = 0;

		LONG prev_tick = 0;
		SYSTEMTIME currentTime;
		
		while (bQuit == false) {
			if (PeekMessage(&msg, NULL, NULL, NULL, PM_REMOVE)) {
				if (msg.message == WM_QUIT) {
					bQuit = true;
				}
				TranslateMessage(&msg);
				DispatchMessage(&msg);
			}
			else {

				GetSystemTime(&currentTime);
				LONG currentTime_ms = (currentTime.wSecond*1000) + currentTime.wMilliseconds;

				double dbDeltaTic = (currentTime_ms - prev_tick)/1000.0;

				switch (g_nGameLoopFSM)
				{
				case 0:
					break;
				case 1:
				{
					HDC hdc = GetDC(msg.hwnd);

					Graphics graphics(hdc);
					//SolidBrush brushRandom(Color(rand() % 256, rand() % 256, rand() % 256));

					backScreen->FillRectangle(&brushBlack, 0, 0, screenRect.Width, screenRect.Height);
					backScreen->FillRectangle(&brushRed, g_nHeroPosX, g_nHeroPosY, 64, 64);

					dbAngle += 90.0 * dbDeltaTic;

					backScreen->TranslateTransform(200, 200);
					backScreen->RotateTransform(dbAngle);
					backScreen->FillRectangle(&brushRed, -32, -32, 64, 64);
					backScreen->ResetTransform();

					graphics.DrawImage(&bmpMem, screenRect);

					ReleaseDC(msg.hwnd, hdc);
				}
				default:
					break;
				}
				prev_tick = currentTime_ms;
			}
		}
	}

	////gdi+ ����
	GdiplusShutdown(gdiplusToken);
}


int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
	_In_opt_ HINSTANCE hPrevInstance,
	_In_ LPWSTR    lpCmdLine,
	_In_ int       nCmdShow)
{
	UNREFERENCED_PARAMETER(hPrevInstance);
	UNREFERENCED_PARAMETER(lpCmdLine);

	// TODO: ���⿡ �ڵ带 �Է��մϴ�.

	// ���� ���ڿ��� �ʱ�ȭ�մϴ�.
	LoadStringW(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
	LoadStringW(hInstance, IDC_EXAM13, szWindowClass, MAX_LOADSTRING);
	MyRegisterClass(hInstance);

	// ���� ���α׷� �ʱ�ȭ�� �����մϴ�.
	if (!InitInstance(hInstance, nCmdShow))
	{
		return FALSE;
	}

	HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_EXAM13));

	MSG msg;

	GDIPLUS_Loop(msg);

	return (int)msg.wParam;
}



//
//  �Լ�: MyRegisterClass()
//
//  ����: â Ŭ������ ����մϴ�.
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
	WNDCLASSEXW wcex;

	wcex.cbSize = sizeof(WNDCLASSEX);

	wcex.style = CS_HREDRAW | CS_VREDRAW;
	wcex.lpfnWndProc = WndProc;
	wcex.cbClsExtra = 0;
	wcex.cbWndExtra = 0;
	wcex.hInstance = hInstance;
	wcex.hIcon = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_EXAM13));
	wcex.hCursor = LoadCursor(nullptr, IDC_ARROW);
	wcex.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
	wcex.lpszMenuName = MAKEINTRESOURCEW(IDC_EXAM13);
	wcex.lpszClassName = szWindowClass;
	wcex.hIconSm = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

	return RegisterClassExW(&wcex);
}

//
//   �Լ�: InitInstance(HINSTANCE, int)
//
//   ����: �ν��Ͻ� �ڵ��� �����ϰ� �� â�� ����ϴ�.
//
//   ����:
//
//        �� �Լ��� ���� �ν��Ͻ� �ڵ��� ���� ������ �����ϰ�
//        �� ���α׷� â�� ���� ���� ǥ���մϴ�.
//
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
	hInst = hInstance; // �ν��Ͻ� �ڵ��� ���� ������ �����մϴ�.

	HWND hWnd = CreateWindowW(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, nullptr, nullptr, hInstance, nullptr);

	if (!hWnd)
	{
		return FALSE;
	}

	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);

	return TRUE;
}

//
//  �Լ�: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  ����:  �� â�� �޽����� ó���մϴ�.
//
//  WM_COMMAND  - ���� ���α׷� �޴��� ó���մϴ�.
//  WM_PAINT    - �� â�� �׸��ϴ�.
//  WM_DESTROY  - ���� �޽����� �Խ��ϰ� ��ȯ�մϴ�.
//
//
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
	case WM_KEYDOWN:
	{
		TCHAR szBuf[256];
		swprintf_s(szBuf, 256, L"%d \n", wParam);
		OutputDebugString(szBuf);

		switch (wParam) {
		case VK_UP:
			if (g_nHeroPosY > 0)
				g_nHeroPosY -= 5;
			break;
		case VK_DOWN:
			if (g_nHeroPosY < 435)
				g_nHeroPosY += 5;
			break;
		case VK_LEFT:
			if (g_nHeroPosX > 0)
				g_nHeroPosX -= 5;
			break;
		case VK_RIGHT:
			if (g_nHeroPosX < 435)
				g_nHeroPosX += 5;
			break;
		default:
			break;
		}
	}break;
	case WM_COMMAND:
	{
		int wmId = LOWORD(wParam);
		// �޴� ������ ���� �м��մϴ�.
		switch (wmId)
		{
		case IDM_ABOUT:
			DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
			break;
		case IDM_EXIT:
			DestroyWindow(hWnd);
			break;
		default:
			return DefWindowProc(hWnd, message, wParam, lParam);
		}
	}
	break;
	case WM_PAINT:
	{
		PAINTSTRUCT ps;
		HDC hdc = BeginPaint(hWnd, &ps);
		// TODO: ���⿡ hdc�� ����ϴ� �׸��� �ڵ带 �߰��մϴ�.
		EndPaint(hWnd, &ps);
	}
	break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	default:
		return DefWindowProc(hWnd, message, wParam, lParam);
	}
	return 0;
}

// ���� ��ȭ ������ �޽��� ó�����Դϴ�.
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
		return (INT_PTR)TRUE;

	case WM_COMMAND:
		if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
		{
			EndDialog(hDlg, LOWORD(wParam));
			return (INT_PTR)TRUE;
		}
		break;
	}
	return (INT_PTR)FALSE;
}