using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;
using System;

public class Qubit 
{
    private float phiAngle;
    private float thetaAngle;
    public Complex zeroValue;
    public Complex oneValue;
    public bool isClassicalBit;

    public Qubit(float phiAngle, float thetaAngle, bool isClassicalBit)
    {
        this.phiAngle = phiAngle;
        this.thetaAngle = thetaAngle;
        this.isClassicalBit = isClassicalBit;
    }

    public void setZeroValue(float phiAngle, float thetaAngle) 
    {

    }

    public void setOneValue(float phiAngle, float thetaAngle) 
    {
     
    }

    public string printBlochVector() 
    {
        throw new NotImplementedException();
    }

    public string printZeroValue() 
    { 
        throw new NotImplementedException();
    }

    public string printOneValue() => throw new NotImplementedException();
}
