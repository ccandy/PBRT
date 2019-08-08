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

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                _m[i, j] = 0.0f;
            }
        }
        _m[0, 0] = _m[1, 1] = _m[2, 2] = _m[3, 3] = 1.0f;
    }

    public Matrix4x4(Matrix4x4 matrix)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                M[i, j] = matrix.M[i, j];
            }
        }
    }

    public Matrix4x4(float t00, float t01, float t02, float t03, 
                     float t10, float t11, float t12, float t13, 
                     float t20, float t21, float t22, float t23,
                     float t30, float t31, float t32, float t33)
    {
        _m[0, 0] = t00;_m[0, 1] = t01;_m[0, 2] = t02;_m[0, 3] = t03;
        _m[1, 0] = t10;_m[1, 1] = t11;_m[1, 2] = t12;_m[1, 3] = t13;
        _m[2, 0] = t20;_m[2, 1] = t21;_m[2, 2] = t22;_m[2, 3] = t23;
        _m[3, 0] = t30;_m[3, 1] = t31;_m[3, 2] = t32;_m[3, 3] = t33;
    }


    public Matrix4x4 Transpose(ref Matrix4x4 m)
    {
        return new Matrix4x4(m.M[0, 0], m.M[1, 0], m.M[2, 0], m.M[3, 0],
                             m.M[0, 1], m.M[1, 1], m.M[2, 1], m.M[3, 1],
                             m.M[0, 2], m.M[1, 2], m.M[2, 2], m.M[3, 2],
                             m.M[0, 3], m.M[1, 3], m.M[2, 3], m.M[3, 3]);
    }

    public static Matrix4x4 mul(Matrix4x4 m1, Matrix4x4 m2)
    {
        Matrix4x4 r = new Matrix4x4();
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                r.M[i,j] =  m1.M[i,0] * m2.M[0,j] +
                            m1.M[i,1] * m2.M[1,j] +
                            m1.M[i,2] * m2.M[2,j] +
                            m1.M[i,3] * m2.M[3,j];
            }
        }
        return r;
    }

}
