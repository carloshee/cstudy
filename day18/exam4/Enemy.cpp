#include "stdafx.h"

void Enemy_OnApply(S_Enemy *pThis, double fDelta)
{
	pThis->m_flifeTime += fDelta;

	switch (pThis->m_nFSM)
	{
	case 0: // ready
		pThis->m_nFSM = 10;
		break;
	case 10: //go
	{
		pThis->m_vPosition += pThis->m_vDirection * pThis->m_fVelocity * fDelta;

		irr::f64 fDist = (pThis->m_vPosition - g_objPlayer.m_vPosition).getLength();

		//총알크기 + 비행기 크기
		if (fDist < (pThis->m_fSize + 12)) {
			AddEffectBulletDie(pThis->m_vPosition);
			pThis->m_nFSM = 999;
		}
		//라이프타임 검사 
		if (pThis->m_flifeTime > 12) {

			pThis->m_nFSM = 999;
		}
	}
	break;
	default:
		break;
	}

}
void Enemy_OnRender(S_Enemy *pThis, Graphics *pGrp, Image *pImg)
{
	pGrp->DrawImage(pThis->m_pImg, RectF((int)(pThis->m_vPosition.X - pThis->m_fSize / 1.0), (int)(pThis->m_vPosition.Y - pThis->m_fSize / 2.0), 43, 35));
}
void Enemy_Setup(S_Enemy *pThis, irr::core::vector2df &vStartPos,
	irr::core::vector2df &vTaegetPos,
	irr::f64 fVolumeSize,
	irr::f64 fVelocity,
	Image *pImg
)
{
	pThis->m_pImg = pImg;
	pThis->m_fSize = fVolumeSize;
	pThis->m_fVelocity = fVelocity;
	pThis->m_nFSM = 0; //ready
	pThis->m_vPosition = vStartPos;
	pThis->m_vDirection = vTaegetPos - vStartPos;
	pThis->m_vDirection.normalize();
	pThis->m_flifeTime = 0;
}