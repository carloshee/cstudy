#include "stdafx.h"

void S_ObjectPlayer_OnApply(S_ObjectPlayer *pThis, double fDelta)
{
	int i = 50;
	if (g_KeyStatus['A']) {
		i = 200;
	}
	if (g_KeyStatus[VK_LEFT]) {
		if(pThis->m_vPosition.X > -300)
			pThis->m_vPosition += fDelta * i * irr::core::vector2df(-1, 0);
	}
	if (g_KeyStatus[VK_RIGHT]) {
		if (pThis->m_vPosition.X < 300)
			pThis->m_vPosition += fDelta * i * irr::core::vector2df(1, 0);
	}

	if (g_KeyStatus[VK_UP]) {
		if (pThis->m_vPosition.Y > -220)
			pThis->m_vPosition += fDelta * i * irr::core::vector2df(0, -1);
	}
	if (g_KeyStatus[VK_DOWN]) {
		if (pThis->m_vPosition.Y < 220)
			pThis->m_vPosition += fDelta * i * irr::core::vector2df(0, 1);
	}
	i = 50;
}

void S_ObjectPlayer_OnRender(S_ObjectPlayer *pThis, Graphics *pGrp)
{
	pGrp->DrawImage(pThis->m_pImg, RectF(pThis->m_vPosition.X - 43/2, pThis->m_vPosition.Y - 35/2, 43, 35));
}

void S_ObjectPlayer_Setup(S_ObjectPlayer *pThis, irr::core::vector2df &startPos, Image *pImg)
{
	pThis->m_pImg = pImg;
	pThis->m_vPosition = startPos;
}