using System.Collections;
using System.Collections.Generic;

public class Interaction
{
    private PBRPoint3   _p;
    private float       _time;
    private PBRVector3  _oError;
    private PBRVector3  wo;
    private PBRNormals  _normal;

    public PBRPoint3 P
    {
        get
        {
            return _p;
        }
    }

    public float ITime
    {
        get
        {
            return _time;
        }
    }

    public PBRVector3 OError
    {
        get
        {
            return _oError;
        }
    }

    public PBRVector3 Wo
    {
        get
        {
            return wo;
        }
    }

    public PBRNormals Normal
    {
        get
        {
            return _normal;
        }
    }





    public Interaction(PBRPoint3 po, PBRNormals normal, PBRVector3 err, PBRVector3 w, float t)
    {
        _time   = t;
        _normal = new PBRNormals(normal);
        _oError = new PBRVector3(err);
        wo      = new PBRVector3(w);
        _p      = new PBRPoint3(po);
    }



}
