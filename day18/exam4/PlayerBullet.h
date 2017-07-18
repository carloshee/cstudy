#pragma once

struct S_PlayerBullet
{
	irr::core::vector2df m_vPosition;
	irr::core::vector2df m_vDirection;
	irr::f64 m_fVelocity;
	irr::f64 m_fSize;
	int m_nFSM;
	double m_flifeTime;
};

extern void PlayerBullet_Setup(S_PlayerBullet *pThis, irr::core::vector2df &vStartPos, irr::core::vector2df &vTaegetPos, irr::f64 fVolumeSize, irr::f64 fVelocity);
extern void PlayerBullet_OnRender(S_PlayerBullet *pThis, Graphics *pGrp);
extern void PlayerBullet_OnApply(S_PlayerBullet *pThis, double fdelta);