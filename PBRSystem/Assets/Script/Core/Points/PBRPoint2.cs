using System.Collections;
using System.Collections.Generic;
using System;
public class PBRPoint2
{
    // Start is called before the first frame update

    #region Variable
    private float _x;
    private float _y;

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
    #endregion
    #region Constructor
    public PBRPoint2()
    {
        _x = _y = 0;
    }

    public PBRPoint3(float x, float y)
    {
        _x = x;
        _y = y;
    }

    public PBRPoint2(PBRPoint2 v)
    {
        _x = v.X;
        _y = v.Y;
    }

    public PBRPoint2(PBRVector2 p)
    {
        _x = p.X;
        _y = p.Y;
    }

    #endregion


    #region Operator

    public static PBRPoint2 operator+(PBRPoint2 p1, PBRPoint2 p2)
    {
        return new PBRPoint2(p1.X + p2.X, p1.Y + p1.Y);
    }
    public static PBRPoint2 operator +(PBRPoint2 p1, PBRVector2 p2)
    {
        return new PBRPoint2(p1.X + p2.X, p1.Y + p1.Y);
    }
    public static PBRPoint2 operator -(PBRPoint2 p1)
    {
        return new PBRPoint2(-p1.X, -p1.Y);
    }
    public static PBRPoint2 operator -(PBRPoint2 p1, PBRPoint2 p2)
    {
        return new PBRPoint2(p1.X - p2.X, p1.Y - p1.Y);
    }
    public static PBRPoint2 operator -(PBRPoint2 p1, PBRVector2 p2)
    {
        return new PBRPoint2(p1.X - p2.X, p1.Y - p1.Y);
    }
    public static PBRPoint2 operator *(PBRPoint2 p1, PBRVector2 p2)
    {
        return new PBRPoint2(p1.X * p2.X, p1.Y * p1.Y);
    }
    public static PBRPoint2 operator /(PBRPoint2 p1, PBRVector2 p2)
    {
        return new PBRPoint2(p1.X / p2.X, p1.Y / p1.Y);
    }
    public static bool operator ==(PBRPoint2 p1, PBRVector2 p2)
    {
        return (p1.X == p2.X) && (p1.Y == p2.Y);
    }
    public static bool operator !=(PBRPoint2 p1, PBRVector2 p2)
    {
        return (p1.X != p2.X) && (p1.Y != p2.Y);
    }

    override
    public bool Equals(object obj)
    {
        if (obj is PBRVector2)
        {
            PBRPoint2 v = (PBRPoint2)obj;
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
