using System.Collections;
using System.Collections.Generic;
using System;
public class PBRPoint2:BaseCoord2D
{
    // Start is called before the first frame update

    #region Variable
    
    #endregion
    #region Constructor
    public PBRPoint2():base()
    {
        
    }

    public PBRPoint2(float x, float y):base(x,y)
    {
        
    }

    public PBRPoint2(PBRPoint2 v):base(v)
    {
        
    }

    public PBRPoint2(PBRVector2 p):base(p)
    {
        
    }

    #endregion


    #region Operator

    public static PBRPoint2 operator +(PBRPoint2 p1, PBRVector2 p2)
    {
        return new PBRPoint2(p1.X + p2.X, p1.Y + p2.Y);
    }

    public static PBRPoint2 operator +(PBRPoint2 p1, PBRPoint2 p2)
    {
        return new PBRPoint2(p1.X + p2.X, p1.Y + p2.Y);
    }

    public static PBRVector2 operator -(PBRPoint2 p1, PBRVector2 p2)
    {
        return new PBRVector2(p1.X - p2.X, p1.Y - p2.Y);
    }
    public static PBRVector2 operator -(PBRPoint2 p1, PBRPoint2 p2)
    {
        return new PBRVector2(p1.X - p2.X, p1.Y - p2.Y);
    }

    public static PBRPoint2 operator -(PBRPoint2 p1)
    {
        return new PBRPoint2(-p1.X, -p1.Y);
    }

    public static PBRPoint2 operator *(PBRPoint2 p1, PBRPoint2 p2)
    {
        return new PBRPoint2(p1.X * p2.X, p1.Y * p2.Y);
    }

    public static PBRPoint2 operator *(PBRPoint2 p1, float s)
    {
        return new PBRPoint2(p1.X * s, p1.Y * s);
    }

    public static PBRPoint2 operator /(PBRPoint2 p1, PBRPoint2 p2)
    {
        return new PBRPoint2(p1.X / p2.X, p1.Y / p2.Y);
    }

    public static PBRPoint2 operator /(PBRPoint2 p1, float s)
    {
        return new PBRPoint2(p1.X / s, p1.Y / s);
    }


    public static bool operator ==(PBRPoint2 p1, PBRVector2 p2)
    {
        return (p1.X == p2.X) && (p1.Y == p2.Y);
    }
    public static bool operator !=(PBRPoint2 p1, PBRVector2 p2)
    {
        return (p1.X != p2.X) && (p1.Y != p2.Y);
    }

    public float Length()
    {
        return (float)Math.Sqrt(LengthSquared());
    }

    public float Distance(PBRPoint2 p1, PBRPoint2 p2)
    {
        return (p2 - p1).Length();
    }
    public float LengthSquared()
    {
        return (_x * _x + _y * _y);
    }
    public float DistanceSquare(PBRPoint2 p1, PBRPoint2 p2)
    {
        return (p2 - p1).LengthSquared();
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
