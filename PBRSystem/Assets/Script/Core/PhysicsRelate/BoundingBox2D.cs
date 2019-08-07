using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundingBox2D
{
    private PBRPoint2 _pMin, _pMax;
    public PBRPoint2 PMin
    {
        set
        {
            _pMin = value;
        }
        get
        {
            return _pMin;
        }
    }

    public PBRPoint2 PMax
    {
        set
        {
            _pMax = value;
        }
        get
        {
            return _pMax;
        }
    }

    public BoundingBox2D()
    {
        _pMax = new PBRPoint2(float.PositiveInfinity, float.PositiveInfinity);
        _pMin = new PBRPoint2(0, 0);
    }

    public BoundingBox2D(PBRPoint2 p)
    {
        _pMin = _pMax = new PBRPoint2(p);
    }

    public BoundingBox2D(PBRPoint2 p1, PBRPoint2 p2)
    {
        _pMin = new PBRPoint2(p1);
        _pMax = new PBRPoint2(p2);
    }

    public float Area()
    {
        PBRVector2 p = _pMax - _pMin;
        return (p.X * p.Y);

    }

    public PBRVector2 Diagonal()
    {
        return _pMax - _pMin;
    }

    public int MaximumExtent()
    {
        PBRVector2 diag = Diagonal();
        if(diag.X > diag.Y)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
    
    public static bool operator ==(BoundingBox2D a, BoundingBox2D b)
    {
        return (a.PMax == b.PMax) && (a.PMin == b.PMin);
    }

    public static bool operator !=(BoundingBox2D a, BoundingBox2D b)
    {
        return (a.PMax != b.PMax) && (a.PMin != b.PMin);
    }

    public PBRVector2 Offset(PBRPoint2 p)
    {
        PBRVector2 o = p -_pMin;
        if(_pMax.X > _pMin.X)
        {
            o.X /= _pMax.X - _pMin.X;
        }
        if(_pMax.Y > _pMin.Y)
        {
            o.Y /= _pMax.Y - _pMin.Y;
        }
        return o;
    }

    public PBRPoint2 Lerp(PBRPoint2 p)
    {
        return new PBRPoint2(Mathf.Lerp(p.X, _pMin.X, _pMax.X), Mathf.Lerp(p.Y, _pMin.Y, _pMax.Y));
    }
    
    public void BoundingSphere(PBRPoint2 p, float rad)
    {
        p = (_pMin + _pMax) / 2;
        rad = Inside(p, this) ? p.Distance(p,_pMax) : 0; 

    }


    public bool Inside(PBRPoint2 p, BoundingBox2D box)
    {
        return (p.X >= box.PMin.X && p.X <= box.PMax.X) && (p.Y >= box.PMin.Y && p.Y <= box.PMax.Y);
    }

    override
    public bool Equals(object obj)
    {
        if (obj is BoundingBox2D)
        {
            BoundingBox2D v = (BoundingBox2D)obj;
            return (this.PMin == v.PMin && this.PMax == v.PMin);
        }
        return false;
    }
    override
    public int GetHashCode()
    {
        return _pMin.GetHashCode() + _pMax.GetHashCode();
    }










}
