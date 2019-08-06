using System.Collections;
using System.Collections.Generic;
using System;
public class PBRPoint3:BaseCoord3D
{
    // Start is called before the first frame update

    
    #region Constructor
    public PBRPoint3():base()
    {
        
    }

    public PBRPoint3(float x, float y, float z):base(x,y,z)
    {
      
    }

    public PBRPoint3(PBRPoint3 v):base(v)
    {
        
    }

    public PBRPoint3(PBRVector3 p):base(p)
    {
        
    }

    #endregion


    #region Operator
    public static bool operator ==(PBRPoint3 p1, PBRVector3 p2)
    {
        return (p1.X == p2.X) && (p1.Y == p2.Y) && (p1.Z == p2.Z);
    }
    public static bool operator !=(PBRPoint3 p1, PBRVector3 p2)
    {
        return (p1.X != p2.X) && (p1.Y != p2.Y) && (p1.Z != p2.Z);
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

    #region operator
    public static PBRPoint3 operator -(PBRPoint3 a, PBRPoint3 b)
    {
        return new PBRPoint3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    public static PBRPoint3 operator -(PBRPoint3 a)
    {
        return new PBRPoint3(-a.X, -a.Y, -a.Z);
    }

    public static PBRPoint3 operator +(PBRPoint3 a, PBRPoint3 b)
    {
        return new PBRPoint3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static PBRPoint3 operator +(PBRPoint3 a, PBRVector3 b)
    {
        return new PBRPoint3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static PBRPoint3 operator *(PBRPoint3 a, float s)
    {
        return new PBRPoint3(a.X * s, a.Y * s, a.Z * s);
    }
    public static PBRPoint3 operator *(PBRPoint3 a, PBRPoint3 b)
    {
        return new PBRPoint3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }


    #endregion


    override
    public int GetHashCode()
    {
        return _x.GetHashCode() + _y.GetHashCode();
    }

    public float LengthSquared()
    {
        return (_x * _x + _y * _y + _z * _z);
    }

    public float Length()
    {
        return (float)Math.Sqrt(LengthSquared());
    }

    public float Distance(PBRPoint3 p1, PBRPoint3 p2)
    {
        return (p2 - p1).Length();
    }

    public float DistanceSquare(PBRPoint3 p1, PBRPoint3 p2)
    {
        return (p2 - p1).LengthSquared();
    }

    public static PBRPoint3 floor(PBRPoint3 p1)
    {
        return new PBRPoint3((float)Math.Floor(p1.X), (float)Math.Floor(p1.Y), (float)Math.Floor(p1.Z));
    }

    public static PBRPoint3 Ceiling(PBRPoint3 p1)
    {
        return new PBRPoint3((float)Math.Ceiling(p1.X), (float)Math.Ceiling(p1.Y), (float)Math.Ceiling(p1.Z));
    }

    


    #endregion



}
