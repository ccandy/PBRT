using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BaseCoord3D
{
    // Start is called before the first frame update
    protected float _x, _y, _z;
    public float X
    {
        set
        {
            _x = value;
        }

        get
        {
            return _x;
        }
    }

    public float Y
    {
        set
        {
            _y = value;
        }

        get
        {
            return _y;
        }
    }
    public float Z
    {
        set
        {
            _z = value;
        }

        get
        {
            return _z;
        }
    }

    #region Contructor
    public BaseCoord3D(float x, float y, float z)
    {
        _x = x;
        _y = y;
        _z = z;

    }

    public BaseCoord3D()
    {
        _x = _y = _z = 0;
    }

    public BaseCoord3D(BaseCoord3D p)
    {
        _x = p.X;
        _y = p.Y;
        _z = p.Z;
    }
    #endregion

    #region operation

    public static BaseCoord3D operator +(BaseCoord3D a, BaseCoord3D b)
    {
        return new BaseCoord3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static BaseCoord3D operator -(BaseCoord3D a, BaseCoord3D b)
    {
        return new BaseCoord3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    public static BaseCoord3D operator -(BaseCoord3D a)
    {
        return new BaseCoord3D(-a.X, -a.Y, -a.Z);
    }

    public static BaseCoord3D operator *(BaseCoord3D a, BaseCoord3D b)
    {
        return new BaseCoord3D(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }

    public static BaseCoord3D operator *(BaseCoord3D a, float s)
    {
        return new BaseCoord3D(a.X * s, a.Y * s, a.Z * s);
    }
    public static BaseCoord3D operator /(BaseCoord3D a, BaseCoord3D b)
    {
        return new BaseCoord3D(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
    }

    public virtual float MaxComponent(BaseCoord3D p1)
    {
        return Math.Max(p1.X, Math.Max(p1.Y, p1.Z));
    }
    public virtual float MinComponent(BaseCoord3D p1)
    {
        return Math.Max(p1.X, Math.Max(p1.Y,p1.Z));
    }

    #endregion



}
