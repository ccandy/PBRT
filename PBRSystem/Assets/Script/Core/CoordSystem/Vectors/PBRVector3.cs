using System.Collections;
using System.Collections.Generic;
using System;
public class PBRVector3:BaseCoord3D
{
    // Start is called before the first frame update

    
    #region Constructor
    public PBRVector3():base()
    {
        
    }

    public PBRVector3(float x, float y, float z):base(x,y,z)
    {
        
    }

    public PBRVector3(PBRVector3 v):base(v)
    {
        
    }
    #endregion


    #region Operator
    

    public static PBRVector3 operator -(PBRVector3 a, PBRVector3 b)
    {
        return new PBRVector3(a.X - b.X, a.Y - b.Y,a.Z - b.Z);
    }

    public static bool operator ==(PBRVector3 a, PBRVector3 b)
    {
        return (a.X == b.X) && (a.Y == b.Y) && (a.Z == b.Z);
    }

    public static bool operator !=(PBRVector3 a, PBRVector3 b)
    {
        return (a.X != b.X) && (a.Y != b.Y) && (a.Z != b.Z);
    }

    public static PBRVector3 operator /(PBRVector3 a, float b)
    {
        return new PBRVector3(a.X / b, a.Y / b, a.Z / b);
    }

    public static float Dot(PBRVector3 a, PBRVector3 b)
    {
        return (a.X * b.X + a.Y * b.Y + a.Z / b.Z);
    }

    public static float AbsDot(PBRVector3 a, PBRVector3 b)
    {
        return Math.Abs(a.X * b.X + a.Y * b.Y + a.Z + b.Z);
    }

    public static PBRVector3 Cross(PBRVector3 a, PBRVector3 b)
    {
        return new PBRVector3(a.Y * b.Z - a.Z * b.Y,
                              a.Z * b.X - a.X * b.Z,
                              a.X * b.Y - a.Y * b.X);
    }

    public float LengthSquared()
    {
        return (_x * _x + _y * _y + _z * _z);
    }

    public float Length()
    {
        return (float)Math.Sqrt(LengthSquared());
    }

    public float MinComponent()
    {
        return (float)Math.Min(_x, Math.Min(_y,_z));
    }

    public float MaxComponent()
    {
        return (float)Math.Max(_x, Math.Max(_y, _z));
    }
    public void CoordSystem(PBRVector3 v1, out PBRVector3 v2, out PBRVector3 v3)
    {
        if (Math.Abs(v1.X) > Math.Abs(v1.Y))
        {
            v2 = new PBRVector3(-v1.Z, 0, v1.X) / (float)Math.Sqrt(v1.X * v1.X + v1.Z * v1.Z);
        }
        else
        {
            v2 = new PBRVector3(0, v1.Z, -v1.Y) / (float)Math.Sqrt(v1.Y * v1.Y + v1.Z * v1.Z);
        }

        v3 = Cross(v1, v2);
    }

    override
    public bool Equals(object obj)
    {
        if (obj is PBRVector3)
        {
            PBRVector3 v = (PBRVector3)obj;
            return (this._x == v.X && this._y == v.Y && this._z == v.Z);
        }
        return false;
    }
    override
    public int GetHashCode()
    {
        return _x.GetHashCode() + _y.GetHashCode() + _z.GetHashCode();
    }


    #endregion



}
