using System.Collections;
using System.Collections.Generic;
using System;
public class PBRVector3
{
    // Start is called before the first frame update

    #region Variable
    private float _x;
    private float _y;
    private float _z;

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


    #endregion
    #region Constructor
    public PBRVector3()
    {
        _x = _y = _z = 0;
    }

    public PBRVector3(float x, float y, float z)
    {
        _x = x;
        _y = y;
        _z = z;
    }

    public PBRVector3(PBRVector3 v)
    {
        _x = v.X;
        _y = v.Y;
        _z = v.Z;
    }
    #endregion


    #region Operator
    public static PBRVector3 operator +(PBRVector3 a, PBRVector3 b)
    {
        return new PBRVector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static PBRVector3 operator -(PBRVector3 a, PBRVector3 b)
    {
        return new PBRVector3(a.X - b.X, a.Y - b.Y,a.Z - b.Z);
    }

    public static PBRVector3 operator *(PBRVector3 a, PBRVector3 b)
    {
        return new PBRVector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }

    public static bool operator ==(PBRVector3 a, PBRVector3 b)
    {
        return (a.X == b.X) && (a.Y == b.Y) && (a.Z == b.Z);
    }

    public static bool operator !=(PBRVector3 a, PBRVector3 b)
    {
        return (a.X != b.X) && (a.Y != b.Y) && (a.Z != b.Z);
    }

    public static PBRVector3 operator /(PBRVector3 a, PBRVector3 b)
    {
        return new PBRVector3(a.X / b.X, a.Y / b.Y);
    }


    override
    public bool Equals(object obj)
    {
        if (obj is PBRVector3)
        {
            PBRVector3 v = (PBRVector3)obj;
            return (this._x == v.X && this._y == v.Y);
        }
        return false;
    }
    override
    public int GetHashCode()
    {
        return _x.GetHashCode() + _y.GetHashCode();
    }


    #endregion



}
