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

    public PrintBlochSettings printSettings;

    public Qubit(float _thetaAngle, float _phiAngle)
    {
        this._thetaAngle = _thetaAngle;
        this._phiAngle = _phiAngle;
        
        printSettings.printSpaces = true;
        printSettings.decimalSpaces = 3;
        printSettings.decimalSeparator = PrintBlochSettings.DecimalSeparator.dot;
        printSettings.imaginaryUnit = PrintBlochSettings.ImaginaryUnit.i;
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

    public string printZeroValue(PrintBlochSettings printSettings) 
    { 
        throw new NotImplementedException();
    }
    public string printOneValue(PrintBlochSettings printSettings) => throw new NotImplementedException();
}
