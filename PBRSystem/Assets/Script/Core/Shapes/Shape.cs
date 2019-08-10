using System.Collections;
using System.Collections.Generic;
using System;

public abstract class Shape
{
    private PBRTransform _objectToWorld, _worldToObject;
    private bool reverseOrientatio, transformSwapsHandedness;


    public PBRTransform ObjectToWorld
    {
        get
        {
            if(_objectToWorld == null)
            {
               _objectToWorld = new PBRTransform();
            }
            return _objectToWorld;
        }
    }

    public PBRTransform WorldToObject
    {
        get
        {
            if(_worldToObject == null)
            {
               _worldToObject = new PBRTransform();
            }
            return _worldToObject;
        }
    }
    
    public Shape()
    {
        _objectToWorld              = new PBRTransform();
        _worldToObject              = new PBRTransform();
        reverseOrientatio           = false;
        transformSwapsHandedness    = false;
    }

    public abstract float Area();
    public abstract BoundingBox3D ObjectBound();
    public abstract BoundingBox3D WorldBound();
    public abstract bool IntersectP(PBRRay ray, bool testAlphaTexture = true);

    









}
