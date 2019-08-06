using System;

public class PBRRay
{
    // Start is called before the first frame update
    protected PBRPoint3       _origin;
    protected PBRVector3      _direction;
    protected float           _tMax;
    protected float           _rTime;
    //private Media         _media;
    public PBRPoint3 Origin
    {
        get
        {
            return _origin;
        }
    }

    public PBRVector3 Direction
    {
        get
        {
            return _direction;
        }
    }

    public float TMax
    {
        get
        {
            return _tMax;
        }
    }

    public float RTime
    {
        get
        {
            return _rTime;
        }
    }

    public PBRRay()
    {
        _origin     = new PBRPoint3();
        _direction  = new PBRVector3();
        _tMax       = float.PositiveInfinity;
        _rTime      = 0.0f;
    }

    public PBRRay(PBRPoint3 p, PBRVector3 d, float tm = float.PositiveInfinity, float rt = 0.0f)
    {
        _origin         = new PBRPoint3(p);
        _direction      = new PBRVector3(d);
        _tMax           = tm;
        _rTime          = rt;
    }

    public PBRRay(PBRRay r)
    {
        _origin     = new PBRPoint3(r.Origin);
        _direction  = new PBRVector3(r.Direction);
        _tMax       = r.TMax;
        _rTime      = r.RTime;
    }

    public PBRPoint3 FindPoint(float t)
    {
        return _origin + _direction * t;
    }

    public virtual bool HasNaNs()
    {
        return _origin.HasNaNs() || _direction.HasNaNs() || float.IsNaN(_tMax);
    }
    




}
