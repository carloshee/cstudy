﻿#pragma once

struct GameObject
{
	//0 ÁØºñ,10 ³¯¾Æ°¡±â, 20 ´ÙÀÌ
	int m_nFSM;
	irr::core::vector2df m_vPosition;
	irr::f64 m_fRotation;
	irr::f64 m_fSpeed;
	irr::f64 m_fFuel;

	Image *m_pImg;
};
extern void GameObject_Draw(GameObject *pThis, Graphics &grp);
extern void GameObject_Apply(GameObject *pThis, irr::f64 fDelta);