using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCoord2D
{
    // Start is called before the first frame update
    #region local varible

    protected float _x, _y;
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

    #region Contructor
    public BaseCoord2D(float x, float y)
    {
        _x = x;
        _y = y;
    }

    public BaseCoord2D()
    {
        _x = _y = 0;
    }

    public BaseCoord2D(BaseCoord2D p)
    {
        _x = p.X;
        _y = p.Y;
    }

    #endregion


    #region operation

    public static BaseCoord2D operator +(BaseCoord2D a, BaseCoord2D b)
    {
        return new BaseCoord2D(a.X + b.X, a.Y + b.Y);
    }

    public static BaseCoord2D operator -(BaseCoord2D a, BaseCoord2D b)
    {
        return new BaseCoord2D(a.X - b.X, a.Y - b.Y);
    }

    public static BaseCoord2D operator -(BaseCoord2D a)
    {
        return new BaseCoord2D(-a.X, -a.Y);
    }

    public static BaseCoord2D operator *(BaseCoord2D a, BaseCoord2D b)
    {
        return new BaseCoord2D(a.X * b.X, a.Y * b.Y);
    }

    public static BaseCoord2D operator *(BaseCoord2D a, float s)
    {
        return new BaseCoord2D(a.X * s, a.Y * s);
    }

    public virtual float MaxComponent(BaseCoord2D p1)
    {
        return Math.Max(p1.X, p1.Y);
    }
    public virtual float MinComponent(BaseCoord2D p1)
    {
        return Math.Max(p1.X, p1.Y);
    }

    #endregion

}
