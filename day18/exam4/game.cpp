#include "stdafx.h"

HWND g_hWnd;

#define MAX_BULLET_LIST 100
#define MAX_EFFECT_BULLETDIE_LIST 100
#define MAX_LINE 8

BYTE g_KeyStatus[256];
int num[3] = { 240, -240, 0 };
int num2[3] = { 320, -320, 0 };
S_ObjectPlayer g_objPlayer;
S_ObjectBullet *g_pBullet_List[MAX_LINE][MAX_BULLET_LIST];
S_PlayerBullet *g_pPlayer_List[MAX_BULLET_LIST];
S_Enemy *g_pEnemy_List[MAX_BULLET_LIST];
//S_ObjectBullet *g_pBullet_List[MAX_BULLET_LIST];
S_ObjectEffectBulletDie *g_pEffectBulletDie_List[MAX_EFFECT_BULLETDIE_LIST];

Image *g_pImgSpaceShip;
Image *g_pImgSpaceShip2;


irr::f64 g_fAcctick = 0;
irr::f64 g_fAcctick2 = 0;

// -1 : 생성 실패
int AddBullet(int N_num)
{
	int i, j, m;
	for (i = 0; i < MAX_BULLET_LIST; i++) {
		if (g_pBullet_List[N_num][i] == NULL) {
			j = rand() % 3;
			if(j == 2){
				m = rand() % 2;
			}
			else
				m = rand() % 3;
			S_ObjectBullet *ptr = (S_ObjectBullet *)malloc(sizeof(S_ObjectBullet));
			ObjectBullet_Setup(ptr, irr::core::vector2df(num2[m], num[j]), g_objPlayer.m_vPosition, 8, rand() % 50 + 20);
			g_pBullet_List[N_num][i] = ptr;
			return i;
		}
	}

	return -1;
}

int AddPlayerBullet() 
{
	int i = 0;
	for (i = 0; i < MAX_BULLET_LIST; i++) {
		if (g_pPlayer_List[i] == NULL) {
			S_PlayerBullet *ptr = (S_PlayerBullet *)malloc(sizeof(S_PlayerBullet));
			PlayerBullet_Setup(ptr, irr::core::vector2df(g_objPlayer.m_vPosition.X, g_objPlayer.m_vPosition.Y), irr::core::vector2df(g_objPlayer.m_vPosition.X, g_objPlayer.m_vPosition.Y - 100), 8, 100);
			g_pPlayer_List[i] = ptr;
			return i;
		}
	}

	return -1;
}

int AddEffectBulletDie(irr::core::vector2df pos)
{
	int i;
		for (i = 0; i < MAX_EFFECT_BULLETDIE_LIST; i++) {
			if (g_pEffectBulletDie_List[i] == NULL) {
				S_ObjectEffectBulletDie *ptr = (S_ObjectEffectBulletDie *)malloc(sizeof(S_ObjectEffectBulletDie));
				ObjectEffectBulletDie_Setup(ptr, pos);
				g_pEffectBulletDie_List[i] = ptr;
				return i;
			}
		}
	return -1;
}

int Enemy()
{
	int i, j, m;
	g_pImgSpaceShip2 = new Image(L"../../res/Enemy.png");

	for (i = 0; i < MAX_BULLET_LIST; i++) {
		if (g_pEnemy_List[i] == NULL) {
			j = rand() % 3;
			if (j == 2) {
				m = rand() % 2;
			}
			else
				m = rand() % 3;
			S_Enemy *ptr = (S_Enemy *)malloc(sizeof(S_Enemy));
			Enemy_Setup(ptr, irr::core::vector2df(num2[m], num[j]), g_objPlayer.m_vPosition, 8, rand() % 50 + 50, g_pImgSpaceShip2);
			g_pEnemy_List[i] = ptr;
			return i;
		}
	}

	return -1;
}

void ClearDeadBulletObj()
{
	int i, j;
	for (j = 0; j < MAX_LINE; j++)
	{
		for (i = 0; i < MAX_BULLET_LIST; i++) {

			if (g_pBullet_List[j][i] != NULL && g_pBullet_List[j][i]->m_nFSM == 999) {
				free(g_pBullet_List[j][i]);
				g_pBullet_List[j][i] = NULL;
			}

			if (g_pEnemy_List[i] != NULL && g_pEnemy_List[i]->m_nFSM == 999) {
				free(g_pEnemy_List[i]);
				g_pEnemy_List[i] = NULL;
			}
		}
	}
}

void ClearDeadEffectBulletDieObj()
{
	int i;
	for (i = 0; i < MAX_EFFECT_BULLETDIE_LIST; i++) {

		if (g_pEffectBulletDie_List[i] != NULL && g_pEffectBulletDie_List[i]->m_nFSM == 999) {
			free(g_pEffectBulletDie_List[i]);
			g_pEffectBulletDie_List[i] = NULL;
		}
	}
}


void OnLoop(double fDelta)
{
	if (fDelta < 0 || fDelta > 1.0) {
		fDelta = 0;
	}
	//시체처리
	ClearDeadBulletObj();
	ClearDeadEffectBulletDieObj();

	//총알 발사
	g_fAcctick += fDelta;
	g_fAcctick2 += fDelta;
	if (g_fAcctick > 1.5) {
		g_fAcctick = 0.0;
		AddBullet(0); AddBullet(1); AddBullet(2); AddBullet(3);
		AddBullet(4); AddBullet(5); AddBullet(6); AddBullet(7); 
		Enemy();
	}
	if (g_fAcctick2 > 0.3) {
		g_fAcctick2 = 0.0;
		if (g_KeyStatus['B']) {
			AddPlayerBullet();
		}
	}
	//플레이어 처리
	S_ObjectPlayer_OnApply(&g_objPlayer, fDelta);

	//총알 처리
	for (int j = 0; j < MAX_LINE; j++) {
		for (int i = 0; i < MAX_BULLET_LIST; i++) {

			S_ObjectBullet *ptr = g_pBullet_List[j][i];
			if (ptr != NULL) {
				ObjectBullet_OnApply(ptr, fDelta);
			}
		}
	}

	for (int i = 0; i < MAX_BULLET_LIST; i++) {

		S_PlayerBullet *ptr = g_pPlayer_List[i];
		if (ptr != NULL) {
			PlayerBullet_OnApply(ptr, fDelta);
		}
	}

	//적 처리
	for (int i = 0; i < MAX_BULLET_LIST; i++) {

		S_Enemy *ptr = g_pEnemy_List[i];
		if (ptr != NULL) {
			Enemy_OnApply(ptr, fDelta);
		}
	}

	//파괴 효과
	for (int i = 0; i < MAX_EFFECT_BULLETDIE_LIST; i++) {

		S_ObjectEffectBulletDie *ptr = g_pEffectBulletDie_List[i];
		if (ptr != NULL) {
			ObjectEffectBulletDie_OnApply(ptr, fDelta);
		}
	}
}

void OnRender(double fDelta, Graphics *pGrp)
{
	pGrp->Clear(Color(200, 191, 231));
	if (fDelta > 0) {
		plusEngine::printf(pGrp, 0, 0, L"fps : %lf", 1.0 / fDelta);
	}
	else {
		plusEngine::printf(pGrp, 0, 0, L"fps : %lf", 1000.f);
	}
	Pen pen(Color(0, 0, 0));
	//Pen pen2(Color(255, 0, 0));
	pGrp->DrawRectangle(&pen, 0, 0, 640, 480);
	pGrp->DrawLine(&pen, 0, 240, 640, 240);
	pGrp->DrawLine(&pen, 320, 0, 320, 480);

	Matrix originMat(1, 0, 0, 1, 320, 240);
	pGrp->SetTransform(&originMat);

	S_ObjectPlayer_OnRender(&g_objPlayer, pGrp);

	for (int j = 0; j < MAX_LINE; j++) {
		for (int i = 0; i < MAX_BULLET_LIST; i++) {
			S_ObjectBullet *ptr = g_pBullet_List[j][i];
			if (ptr != NULL) {
				ObjectBullet_OnRender(ptr, pGrp);
			}
		}
	}

	for (int i = 0; i < MAX_BULLET_LIST; i++) {
		S_PlayerBullet *ptr = g_pPlayer_List[i];
		if (ptr != NULL) {
			PlayerBullet_OnRender(ptr, pGrp);
		}
	}

	g_pImgSpaceShip2 = new Image(L"../../res/Enemy.png");
	for (int i = 0; i < MAX_BULLET_LIST; i++) {
		S_Enemy *ptr = g_pEnemy_List[i];
		if (ptr != NULL) {
			Enemy_OnRender(ptr, pGrp, g_pImgSpaceShip2);
		}
	}

	//파괴 효과
	for (int i = 0; i < MAX_EFFECT_BULLETDIE_LIST; i++) {

		S_ObjectEffectBulletDie *ptr = g_pEffectBulletDie_List[i];
		if (ptr != NULL) {
			ObjectEffectBulletDie_OnRender(ptr, pGrp);
		}
	}

	pGrp->ResetTransform();

}

void OnCreate(HWND hWnd)
{
	g_hWnd = hWnd;
	plusEngine::fpOnLoop = OnLoop;
	plusEngine::fpOnRender = OnRender;
	//키상태 초기화 
	for (int i = 0; i < 256; i++) {
		g_KeyStatus[i] = 0;
	}

	for (int j = 0; j < MAX_LINE; j++) {
		for (int i = 0; i < MAX_BULLET_LIST; i++) {
			g_pBullet_List[j][i] = NULL;
		}
	}

	for (int i = 0; i < MAX_BULLET_LIST; i++) {
		g_pPlayer_List[i] = NULL;
	}

	for (int i = 0; i < MAX_BULLET_LIST; i++) {
		g_pEnemy_List[i] = NULL;
	}
	
	for (int i = 0; i < MAX_EFFECT_BULLETDIE_LIST; i++) {
		g_pEffectBulletDie_List[i] = NULL;
	}

	g_pImgSpaceShip = new Image(L"../../res/spaceship_crop.png");

	S_ObjectPlayer_Setup(&g_objPlayer, irr::core::vector2df(0, 0), g_pImgSpaceShip);
	//ObjectBullet_Setup(&g_TestBullet, irr::core::vector2df(-160, -120), g_objPlayer.m_vPosition, 8, 30);

}

void OnDestory(HWND hWnd)
{
	delete g_pImgSpaceShip;

	int i, j;
	for (j = 0; j < MAX_LINE; j++) {
		for (i = 0; i < MAX_BULLET_LIST; i++) {
			if (g_pBullet_List[j][i] != NULL) {
				free(g_pBullet_List[j][i]);
			}
		}
	}

	for (i = 0; i < MAX_BULLET_LIST; i++) {
		if (g_pPlayer_List[i] != NULL) {
			free(g_pPlayer_List[i]);
		}
	}

	for (i = 0; i < MAX_BULLET_LIST; i++) {
		if (g_pEnemy_List[i] != NULL) {
			free(g_pEnemy_List[i]);
		}
	}
}