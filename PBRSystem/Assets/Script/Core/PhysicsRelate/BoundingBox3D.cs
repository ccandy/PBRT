using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundingBox3D
{
    private PBRPoint3 _pMax, _pMin;

    public PBRPoint3 PMax
    {
        get
        {
            return _pMax;
        }
    }

    public PBRPoint3 PMin
    {
        get
        {
            return _pMin;
        }
    }



    public BoundingBox3D()
    {
        _pMax = new PBRPoint3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
        _pMin = new PBRPoint3(0, 0, 0);

    }

    public BoundingBox3D(PBRPoint3 p)
    {
        _pMax = new PBRPoint3(p);
        _pMin = new PBRPoint3(p);
    }

    public BoundingBox3D(PBRPoint3 p1, PBRPoint3 p2)
    {
        _pMin = new PBRPoint3(p1);
        _pMax = new PBRPoint3(p2);
    }

    public static bool operator ==(BoundingBox3D b1, BoundingBox3D b2)
    {
        return (b1.PMax == b2.PMax) && (b1.PMin == b2.PMax);
    }

    public static bool operator !=(BoundingBox3D b1, BoundingBox3D b2)
    {
        return (b1.PMax != b2.PMax) || (b1.PMin != b2.PMax);
    }

    

    public PBRVector3 Diagonal()
    {
        return _pMax - _pMin;
    }

    
    public float SurfaceArea()
    {
        PBRVector3 d = Diagonal();
        return 2 * (d.X * d.Y + d.X * d.Z + d.Y * d.Z);
    }

    public float Volume()
    {
        PBRVector3 d = Diagonal();
        return d.X * d.Y * d.Z;
    }

    public int MaximumExtent()
    {
        PBRVector3 d = Diagonal();
        if(d.X > d.Y && d.X > d.Z)
        {
            return 0;
        }else if(d.Y > d.Z)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    public PBRPoint3 Lerp(PBRPoint3 p)
    {
        return new PBRPoint3(
            Mathf.Lerp(p.X, _pMin.X, _pMax.X),
            Mathf.Lerp(p.Y, _pMin.Y, _pMax.Y),
            Mathf.Lerp(p.Z, _pMin.Z, _pMax.Z));
    }

    public PBRVector3 Offset(PBRPoint3 p)
    {
        PBRVector3 o = p - _pMin;
        if (_pMax.X > _pMin.X) p.X /= _pMax.X - _pMin.X;
        if (_pMax.Y > _pMin.Y) p.Y /= _pMax.Y - _pMin.Y;
        if (_pMax.Z > _pMin.Z) p.Z /= _pMax.Z - _pMin.Z;

        return o;
    }

    public void BoundingSphere(out PBRPoint3 center, out float rad)
    {
        center  = (_pMin + _pMax) / 2.0f;
        rad = 0; 
    }

    public static bool Inside(PBRPoint3 p, BoundingBox3D b)
    {
        return (p.X >= b.PMin.X && p.X <= b.PMax.X &&
            p.Y >= b.PMin.Y && p.Y <= b.PMax.Y &&
            p.Z >= b.PMin.Z && p.Z <= b.PMax.Z);
    }

    public static bool Overlap(BoundingBox3D b1, BoundingBox3D b2)
    {
        bool x = (b1.PMax.X >= b2.PMin.X) && (b1.PMin.X <= b2.PMax.X);
        bool y = (b1.PMax.Y >= b2.PMin.Y) && (b1.PMin.Y <= b2.PMax.Y);
        bool z = (b1.PMax.Z >= b2.PMin.Z) && (b1.PMin.Z <= b2.PMax.Z);

        return (x && y && z);
    }

    public static BoundingBox3D Intersect(BoundingBox3D b1, BoundingBox3D b2)
    {
        PBRPoint3 pmin = new PBRPoint3(Mathf.Max(b1.PMin.X, b2.PMin.X),
                                               Mathf.Max(b1.PMin.Y, b2.PMin.Y),
                                               Mathf.Max(b1.PMin.Z, b2.PMin.Z));
        PBRPoint3 pmax = new PBRPoint3(Mathf.Min(b1.PMax.X, b2.PMax.X),
                                               Mathf.Min(b1.PMax.Y, b2.PMax.Y),
                                               Mathf.Min(b1.PMax.Z, b2.PMax.Z));
        return new BoundingBox3D(pmin,pmax);
    }

    public static BoundingBox3D Union(BoundingBox3D b1, BoundingBox3D b2)
    {
        PBRPoint3 pmin = new PBRPoint3(Mathf.Min(b1.PMin.X, b2.PMin.X),
                                               Mathf.Min(b1.PMin.Y, b2.PMin.Y),
                                               Mathf.Min(b1.PMin.Z, b2.PMin.Z));
        PBRPoint3 pmax = new PBRPoint3(Mathf.Max(b1.PMax.X, b2.PMax.X),
                                               Mathf.Max(b1.PMax.Y, b2.PMax.Y),
                                               Mathf.Max(b1.PMax.Z, b2.PMax.Z));
        return new BoundingBox3D(pmin, pmax);
    }

    public static BoundingBox3D Expand(BoundingBox3D b, float delta)
    {
        return new BoundingBox3D(b.PMin - new PBRVector3(delta, delta, delta),
                      b.PMax + new PBRVector3(delta, delta, delta));
    }


    public static bool InsideExclusive(PBRPoint3 p, BoundingBox3D b)
    {
        return (p.X >= b.PMin.X && p.X < b.PMax.X) && (p.Y >= b.PMin.Y && p.Y < b.PMax.Y) && (p.Z >= b.PMin.Z && p.Z < b.PMax.Z);
    }





    override
    public bool Equals(object obj)
    {
        if (obj is BoundingBox2D)
        {
            BoundingBox3D v = (BoundingBox3D)obj;
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
