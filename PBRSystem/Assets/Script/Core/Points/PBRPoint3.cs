using System.Collections;
using System.Collections.Generic;
using System;
public class PBRPoint3
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
    public PBRPoint3()
    {
        _x = _y = 0;
    }

    public PBRPoint3(float x, float y, float z)
    {
        _x = x;
        _y = y;
    }

    public PBRPoint3(PBRPoint3 v)
    {
        _x = v.X;
        _y = v.Y;
        _z = v.Z;
    }

    public PBRPoint3(PBRVector3 p)
    {
        _x = p.X;
        _y = p.Y;
        _z = p.Z;
    }

    #endregion


    #region Operator

    public static PBRPoint3 operator+(PBRPoint3 p1, PBRPoint3 p2)
    {
        return new PBRPoint3(p1.X + p2.X, p1.Y + p2.Y);
    }
    public static PBRPoint3 operator +(PBRPoint3 p1, PBRVector3 p2)
    {
        return new PBRPoint3(p1.X + p2.X, p1.Y + p1.Y);
    }
    public static PBRPoint3 operator -(PBRPoint3 p1)
    {
        return new PBRPoint3(-p1.X, -p1.Y);
    }
    public static PBRPoint3 operator -(PBRPoint3 p1, PBRPoint3 p2)
    {
        return new PBRPoint3(p1.X - p2.X, p1.Y - p1.Y);
    }
    public static PBRPoint3 operator -(PBRPoint3 p1, PBRVector3 p2)
    {
        return new PBRPoint3(p1.X - p2.X, p1.Y - p1.Y);
    }
    public static PBRPoint3 operator *(PBRPoint3 p1, PBRVector3 p2)
    {
        return new PBRPoint3(p1.X * p2.X, p1.Y * p1.Y);
    }
    public static PBRPoint3 operator /(PBRPoint3 p1, PBRVector3 p2)
    {
        return new PBRPoint3(p1.X / p2.X, p1.Y / p1.Y);
    }
    public static bool operator ==(PBRPoint3 p1, PBRVector3 p2)
    {
        return (p1.X == p2.X) && (p1.Y == p2.Y);
    }
    public static bool operator !=(PBRPoint3 p1, PBRVector3 p2)
    {
        return (p1.X != p2.X) && (p1.Y != p2.Y);
    }

    override
    public bool Equals(object obj)
    {
        if (obj is PBRVector3)
        {
            PBRPoint3 v = (PBRPoint3)obj;
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
