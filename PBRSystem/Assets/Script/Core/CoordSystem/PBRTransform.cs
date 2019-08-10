using System.Collections;
using System.Collections.Generic;
public class PBRTransform
{


    private Matrix4x4 m;
    private Matrix4x4 mInv;

    public Matrix4x4 M
    {
        get
        {
            return m;
        }
    }

    public Matrix4x4 MInv
    {
        get
        {
            return mInv;
        }
    }


    public PBRTransform()
    {
        m       = new Matrix4x4();
        mInv    = new Matrix4x4();
    }
    public PBRTransform(Matrix4x4 m, Matrix4x4 mInv)
    {
        this.m      = new Matrix4x4(m);
        this.mInv   = new Matrix4x4(mInv);
    }

    public PBRTransform Inverse()
    {
        return new PBRTransform(mInv, m);
    }

    public PBRTransform Tranpose(PBRTransform t)
    {
        return new PBRTransform(Matrix4x4.Transpose(ref m), Matrix4x4.Transpose(ref mInv));
    }

    
    public static bool operator ==(PBRTransform t1, PBRTransform t2)
    {
        return t1.M == t2.M && t1.MInv == t2.MInv;
    }
    
    public static bool operator !=(PBRTransform t1, PBRTransform t2)
    {
        return t1.M != t2.M && t1.MInv != t2.MInv;
    }

    public static bool operator < (PBRTransform t1, PBRTransform t2)
    {
        for (int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if (t1.M.M[i, j] < t2.M.M[i, j]) return true;
                if (t1.M.M[i, j] > t2.M.M[i, j]) return false;
            }
        }

        return false;
    }

    public static bool operator >(PBRTransform t1, PBRTransform t2)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (t1.M.M[i, j] < t2.M.M[i, j]) return false;
                if (t1.M.M[i, j] > t2.M.M[i, j]) return true;
            }
        }

        return false;
    }

    public static PBRTransform Translate(PBRVector3 delta)
    {
        Matrix4x4 m     = new Matrix4x4(1, 0, 0, delta.X,
                                        0, 1, 0, delta.Y,
                                        0, 0, 1, delta.Z,
                                        0, 0, 0, 1);
        Matrix4x4 invM  = new Matrix4x4(1, 0, 0, -delta.X,
                                        0, 1, 0, -delta.Y,
                                        0, 0, 1, -delta.Z,
                                        0, 0, 0, 1);
        return new PBRTransform(m, invM);
    }

    public static PBRTransform Scale(float x, float y, float z)
    {
        Matrix4x4 m = new Matrix4x4(x, 0, 0, 0,
                                    0, y, 0, 0,
                                    0, 0, z, 0,
                                    0, 0, 0, 1);
        Matrix4x4 invM = new Matrix4x4(1 / x, 0, 0,0,
                                       0, 1 / y, 0, 0,
                                       0, 0, 1 / z, 0,
                                       0, 0, 0, 1);
        return new PBRTransform(m, invM);
    }

    public PBRTransform LookAt(PBRPoint3 pos, PBRPoint3 look, PBRVector3 up)
    {
        Matrix4x4 cameraToWorld = new Matrix4x4();
        cameraToWorld.M[0, 3] = pos.X;
        cameraToWorld.M[1, 3] = pos.Y;
        cameraToWorld.M[2, 3] = pos.Z;
        cameraToWorld.M[2, 3] = 1;

        return null;



    }







}
