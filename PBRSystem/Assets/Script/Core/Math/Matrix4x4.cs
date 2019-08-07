using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrix4x4
{
    private float[,] _m = new float[4,4];
    public float[,] M
    {
        get
        {
            return _m;
        }

        set
        {
            _m = value;
        }

    }

    public Matrix4x4()
    {
        _m[0, 0] = _m[1, 1] = _m[2, 2] = _m[3, 3] = 1.0f;

    }




}
