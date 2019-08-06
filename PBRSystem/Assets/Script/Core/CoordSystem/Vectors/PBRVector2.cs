using System.Collections;
using System.Collections.Generic;
using System;
public class PBRVector2:BaseCoord2D
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
    public PBRVector2()
    {
        _x = _y = 0;
    }

    public PBRVector2(float x, float y)
    {
        _x = x;
        _y = y;
    }

    public PBRVector2(PBRVector2 v)
    {
        _x = v.X;
        _y = v.Y;
    }
    #endregion


    #region Operator
    public static PBRVector2 operator +(PBRVector2 a, PBRVector2 b)
    {
        return new PBRVector2(a.X + b.X, a.Y + b.Y);
    }

    public static PBRVector2 operator -(PBRVector2 a, PBRVector2 b)
    {
        return new PBRVector2(a.X - b.X, a.Y - b.Y);
    }

    public static PBRVector2 operator *(PBRVector2 a, PBRVector2 b)
    {
        return new PBRVector2(a.X * b.X, a.Y * b.Y);
    }
    public static PBRVector2 operator *(PBRVector2 a, float s)
    {
        return new PBRVector2(a.X * s, a.Y * s);
    }

    public static bool operator==(PBRVector2 a, PBRVector2 b)
    {
        return (a.X == b.X) && (a.Y == b.Y);
    }

    public static bool operator !=(PBRVector2 a, PBRVector2 b)
    {
        return (a.X != b.X) && (a.Y != b.Y);
    }
    
    public static PBRVector2 operator /(PBRVector2 a, PBRVector2 b)
    {
        return new PBRVector2(a.X / b.X,a.Y / b.Y);
    }

    public static float AbsDot(PBRVector2 a, PBRVector2 b)
    {
        return Math.Abs(a.X * b.X + a.Y * b.Y);
    }

    override
    public bool Equals(object obj)
    {
        if(obj is PBRVector2)
        {
            PBRVector2 v = (PBRVector2)obj;
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
