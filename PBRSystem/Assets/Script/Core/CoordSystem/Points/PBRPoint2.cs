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
