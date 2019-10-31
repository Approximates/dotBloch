using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;
using System;
using static PrintBlochSettings;

public class Qubit 
{
    private float _phiAngle;
    private float _thetaAngle;
    private Complex zeroValue;
    private Complex oneValue;

    public PrintBlochSettings printSettings;

    public Qubit(float thetaAngle, float phiAngle)
    {
        this._thetaAngle = thetaAngle;
        this._phiAngle = phiAngle;
        
        printSettings = new PrintBlochSettings(true,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
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
    public string printBlochVector(PrintBlochSettings printSettings = null) 
    {
        throw new NotImplementedException();
    }

    public string printZeroValue(DecimalSeparator? decimalSeparator = null) 
    { 
        throw new NotImplementedException();
    }
    public string printOneValue(bool leadingPlus,PrintBlochSettings printSettings = null) => throw new NotImplementedException();
}
