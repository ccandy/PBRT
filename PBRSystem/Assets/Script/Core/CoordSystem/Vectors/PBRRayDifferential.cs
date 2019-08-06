using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBRRayDifferential : PBRRay
{
    private bool _hasDifferentials;
    private PBRPoint3 rxOrigin, ryOrigin;
    private PBRVector3 rxDirection, ryDirection;


    public PBRRayDifferential()
    {
        _hasDifferentials = false;
    }

    public PBRRayDifferential(PBRPoint3 p, PBRVector3 d, float tMax = float.PositiveInfinity, float pTime = 0.0f) : base(p, d, tMax, pTime)
    {
        _hasDifferentials = false;
    }

    public PBRRayDifferential(PBRRay r) : base(r)
    {
        _hasDifferentials = false;
    }
    override
    public bool HasNaNs()
    {
        return base.HasNaNs() || rxOrigin.HasNaNs() || ryOrigin.HasNaNs() || rxDirection.HasNaNs() || ryDriection.HasNaNs();
    }

    public void ScaleDifferential(float s)
    {
        rxOrigin    = _origin + (rxOrigin - _origin) * s;
        ryOrigin    = _origin + (ryOrigin - _origin) * s;
        rxDirection = _direction + (rxDirection - _direction) * s;
        ryDirection = _direction + (ryDirection - _direction) * s;
    }


}
