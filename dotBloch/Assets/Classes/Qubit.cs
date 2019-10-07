using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;
using System;

public class Qubit 
{
    private float _phiAngle;
    private float _thetaAngle;
    private Complex zeroValue;
    private Complex oneValue;
    public bool isClassicalBit;

    public Qubit(float _phiAngle, float _thetaAngle, bool isClassicalBit)
    {
        this._phiAngle = _phiAngle;
        this._thetaAngle = _thetaAngle;
        this.isClassicalBit = isClassicalBit;
    }

#region geters_and_setters
    public float phiAngle
    {
        get 
        {
            return _phiAngle;
        }
        set
        {
            //add validators
            _phiAngle = value;
        }
    }

    public float thetaAngle
    {
        get
        {
            return _thetaAngle;
        }
        set
        {
            //add validators
            _thetaAngle = value;
        }
    }
#endregion
    public void updateAngles(float _phiAngle, float _thetaAngle)
    {
        throw new NotImplementedException();
    }

    public string printBlochVector(int decimalPlaces) 
    {
        throw new NotImplementedException();
    }

    public string printZeroValue(int decimalPlaces) 
    { 
        throw new NotImplementedException();
    }
    public string printOneValue(bool printPlus, int decimalPlaces) => throw new NotImplementedException();
}
