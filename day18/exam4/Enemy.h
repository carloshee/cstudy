#pragma once

struct S_Enemy
{
	irr::core::vector2df m_vPosition;
	irr::core::vector2df m_vDirection;
	irr::f64 m_fVelocity;
	irr::f64 m_fSize;
	int m_nFSM;
	double m_flifeTime;
	Image *m_pImg;
};

extern void Enemy_Setup(S_Enemy *pThis, irr::core::vector2df &vStartPos, irr::core::vector2df &vTaegetPos, irr::f64 fVolumeSize, irr::f64 fVelocity, Image *pImg);
extern void Enemy_OnRender(S_Enemy *pThis, Graphics *pGrp, Image *pImg);
extern void Enemy_OnApply(S_Enemy *pThis, double fdelta);