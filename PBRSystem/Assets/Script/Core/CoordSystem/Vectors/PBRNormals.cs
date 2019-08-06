using System.Collections;
using System.Collections.Generic;
using System;

public class PBRNormals : PBRVector3
{
    #region contructor

    public PBRNormals():base(){ }
    public PBRNormals(float x, float y, float z) : base(x, y, z) { }
    public PBRNormals(PBRNormals p) : base(p) { }

    #endregion

    #region operator

    public static PBRNormals operator /(PBRNormals n, float s)
    {
        return new PBRNormals(n.X / s, n.Y / s, n.Z / s);
    }

    public static PBRNormals operator -(PBRNormals n)
    {
        return new PBRNormals(-n.X , -n.Y, -n.Z);
    }

    public static PBRNormals PBRNormalize(PBRNormals n)
    {
        return n / n.Length();
    }

    


    public static PBRNormals FaceForward(PBRNormals a, PBRNormals b)
    {
        float d = Dot(a, b);
        if (d < 0)
        {
            return -a;
        }
        return -b;    
    }


    #endregion
}
