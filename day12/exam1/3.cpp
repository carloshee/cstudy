#include "stdafx.h"
#include "../../engine/utils.h"

void procTest3(HWND hWnd)
{
	int nums_1[3][4] = { 
		1, 2, 3, 4, 5, 6, 
		7, 8, 9, 10, 11, 12 };

	int nums_2[2][6] = { 
		1, 2, 3, 4, 
		5, 6, 7, 8, 
		9, 10, 11, 12 };

	int nums_3[12] = {
		1, 2, 3, 4,
		5, 6, 7, 8,
		9, 10, 11, 12 };

	win32_Printf(hWnd, L"[0][0] : %d %d", nums_1[0][0], nums_2[0][0]);

	int col = 0;
	int row = 1;

	win32_Printf(hWnd, L"[1][0] : %d %d", nums_1[row][col], nums_2[row][col]);

	win32_Printf(hWnd, L"[0][0] : %d %d", nums_3[4 *row + col], nums_3[6 * row + col]);

	//14-2 ¹®Á¦
	int nDatas[5][6] = {
		1, 2, 3, 4, 5, 0,
		6, 7, 8, 9, 10, 0,
		11, 12, 13, 14, 15, 0,
		16, 17, 18, 19, 20, 0,
		0, 0, 0, 0, 0, 0
	};

	for (int j = 0; j < 5; j++) {
		//for (int i = 0; i < 6; i++) 
		{
			nDatas[j][5] = nDatas[j][0] + nDatas[j][1] + nDatas[j][2] + nDatas[j][3] + nDatas[j][4];
			if (j == 4) {
				for (int i = 0; i < 6; i++) {
					nDatas[j][i] = nDatas[0][i] + nDatas[1][i] + nDatas[2][i] + nDatas[3][i];
				}
			}
			win32_Printf(hWnd, L"%d %d %d %d %d %d", nDatas[j][0], nDatas[j][1], nDatas[j][2], nDatas[j][3], nDatas[j][4], nDatas[j][5]);
		}
	}


}